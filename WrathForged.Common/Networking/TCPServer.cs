// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks.Dataflow;
using Microsoft.Extensions.Configuration;
using Serilog;

#pragma warning disable CS8618

namespace WrathForged.Common.Networking;

public class TCPServer
{
    public enum ConnectionState
    {
        Connected,
        Disconnected
    }

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
        Task.Run(ListenForConnections);
        _logger.Information("Listening for TCP connections on {BindIP}:{Port}", bindIp, port);
    }

    public void Stop()
    {
        if (_tcpListener == null)
            return;

        _tcpListener.Stop();

        lock (_clients)
        {
            foreach (var client in _clients.ToList()) // avoid modifying the collection while iterating
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

        _logger.Debug("Client removed from TCPServer from {Address}", clientSocket.IPEndPoint.Address.ToString());

        _ = _connectionProcessingBlock.Post(new ClientConnectionChangeEvent(clientSocket, OnClientDisconnected, ConnectionState.Disconnected));
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

                                    _logger.Verbose("Received {DataLength} bytes from {Address}", data.Data.Length, data.Client.IPEndPoint.Address.ToString());

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

                                        _logger.Verbose("Client connection change: {Status} from {Address}", data.ConnectionState.ToString(), data.Client.IPEndPoint.Address.ToString());

                                        foreach (var handler in data.EventHandler.GetInvocationList().Cast<EventHandler<ClientSocket>>())
                                        {
                                            try
                                            {
                                                handler?.Invoke(this, data.Client);
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

    private void ListenForConnections()
    {
        while (!_programExit.IsExiting)
        {
            try
            {
                var client = _tcpListener.AcceptTcpClient();

                if (client == null || !client.Connected)
                    continue;

                _logger.Debug("TCP Listener: Client connected from {Address}", client.Client.RemoteEndPoint);
                var clientSocket = new ClientSocket(client, _logger, _dataProcessingBlock);
                clientSocket.OnDisconnect += (sender, args) => RemoveClient(args);

                lock (_clients)
                    _clients.Add(clientSocket);

                _ = _connectionProcessingBlock.Post(new ClientConnectionChangeEvent(clientSocket, OnClientConnected, ConnectionState.Connected));
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error accepting client");
            }
        }
    }
}