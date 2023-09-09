// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks.Dataflow;
using Microsoft.Extensions.Configuration;
using Serilog;

#pragma warning disable CS8618

namespace WrathForged.Common.Networking
{
    public class TCPServer
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger _logger;
        private readonly ProgramExitNotifier _programExit;
        private TcpListener _tcpListener;
        private readonly List<ClientSocket> _clients = new();
        private ActionBlock<DataReceivedEventArgs> _dataProcessingBlock;
        private ActionBlock<ClientConnectionChangeEvent> _connectionProcessingBlock;

        public TCPServer(IConfiguration configuration, ILogger logger, ProgramExitNotifier programExit)
        {
            _configuration = configuration;
            _logger = logger;
            _programExit = programExit;
            _programExit.ExitProgram += (sender, args) => Stop();
            SetupTPL();
        }

        public EventHandler<ClientSocket> OnClientConnected;
        public EventHandler<ClientSocket> OnClientDisconnected;

        public void Start(int defaultPort = 8085)
        {
            var bindIpString = _configuration.GetDefaultValue("ClientTCPServer:BindIP", "*");
            var bindIp = IPAddress.Any;

            if (bindIpString != "*")
            {
                if (IPAddress.TryParse(bindIpString, out var newAddress))
                {
                    bindIp = newAddress;
                }
                else
                {
                    _logger.Error("Invalid IP address specified for configuration: ClientTCPServer:BindIP");
                }
            }

            Start(_configuration.GetDefaultValue("ClientTCPServer:Port", defaultPort), bindIp);
        }

        public void Start(int port, IPAddress? bindIp = null)
        {
            bindIp ??= IPAddress.Any;

            if (_tcpListener != null)
            {
                _logger.Warning("TcpListener already started.");
                return;
            }

            _tcpListener = new TcpListener(bindIp, port);
            _tcpListener.Start();
            _ = _tcpListener.BeginAcceptTcpClient(OnAccept, _tcpListener);
            _logger.Information("Listening for TCP connections on {BindIP}:{Port}", bindIp, port);
        }

        public void Stop()
        {
            if (_tcpListener == null)
                return;

            _tcpListener.Stop();

            lock (_clients)
            {
                foreach (var client in _clients)
                {
                    client.Disconnect();
                }

                _clients.Clear();
            }

            _logger.Information("Stopped listening for TCP connections");
        }

        internal void RemoveClient(ClientSocket clientSocket)
        {
            lock (_clients)
            {
                _ = _clients.Remove(clientSocket);
            }

            _ = _connectionProcessingBlock.Post(new ClientConnectionChangeEvent(clientSocket, OnClientDisconnected));
        }

        private void SetupTPL()
        {
            _dataProcessingBlock = new ActionBlock<DataReceivedEventArgs>(
               data =>
               {
                   if (data.EventHandler == null)
                   {
                       return;
                   }

                   foreach (var handler in data.EventHandler.GetInvocationList().Cast<EventHandler<DataReceivedEventArgs>>())
                   {
                       try
                       {
                           handler?.Invoke(this, data);
                       }
                       catch (Exception ex)
                       {
                           _logger.Error(ex, "Error processing data from client");
                       }
                   }
               },
               new ExecutionDataflowBlockOptions
               {
                   MaxDegreeOfParallelism = _configuration.GetDefaultValue("ClientTCPServer:Threads", 20), // Limit the number of concurrent operations
                   CancellationToken = _programExit.GetCancellationToken(),
                   EnsureOrdered = true,
                   NameFormat = "ClientTCPServer Data Processing Thread {1}"
               });

            _connectionProcessingBlock = new ActionBlock<ClientConnectionChangeEvent>(
                data =>
                {
                    if (data.EventHandler == null)
                    {
                        return;
                    }

                    foreach (var handler in data.EventHandler.GetInvocationList().Cast<EventHandler<ClientConnectionChangeEvent>>())
                    {
                        try
                        {
                            handler?.Invoke(this, data);
                        }
                        catch (Exception ex)
                        {
                            _logger.Error(ex, "Error connection change of client");
                        }
                    }
                },
                new ExecutionDataflowBlockOptions
                {
                    MaxDegreeOfParallelism = _configuration.GetDefaultValue("ClientTCPServer:Threads", 20), // Limit the number of concurrent operations
                    CancellationToken = _programExit.GetCancellationToken(),
                    EnsureOrdered = true,
                    NameFormat = "Client Connection Change Thread {1}"
                });
        }

        private void OnAccept(IAsyncResult ar)
        {
            if (_programExit.IsExiting)
            {
                return;
            }

            var client = _tcpListener.EndAcceptTcpClient(ar);

            if (client == null || !client.Connected)
            {
                return;
            }

            var clientSocket = new ClientSocket(client, _logger, _dataProcessingBlock);
            clientSocket.OnDisconnect += (sender, args) => RemoveClient(clientSocket);

            lock (_clients)
            {
                _clients.Add(clientSocket);
            }

            _ = _connectionProcessingBlock.Post(new ClientConnectionChangeEvent(clientSocket, OnClientConnected));
        }
    }
}