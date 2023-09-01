// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Buffers.Binary;
using Serilog;

namespace WrathForged.Common.Networking
{
    public class WoWClientSession
    {
        private byte[] _sessionKey;
        private readonly int _encrypt;
        private readonly ILogger _logger;
        private int _decryptSeq;
        public int DecryptUntil = -1;

        public WoWClientSession(ClientSocket clientSocket, PacketBuffer packetBuffer, ILogger logger)
        {
            ClientSocket = clientSocket;
            PacketBuffer = packetBuffer;
            _logger = logger;
        }

        public byte[] SessionKey
        {
            get { return _sessionKey; }
            set
            {
                _sessionKey = value;
                PacketEncryption = new PacketEncryption(value);
            }
        }

        public bool IsEncrypted
        {
            get { return _sessionKey != null; }
        }

        public PacketEncryption PacketEncryption { get; private set; }
        public ClientSocket ClientSocket { get; }
        public PacketBuffer PacketBuffer { get; }

        public byte GetDecryptedByte(Memory<byte> inputData, int baseOffset, int offset)
        {
            if (Interlocked.Exchange(ref _decryptSeq, 1) == 1)
                _logger.Warning("Decrypting out of order packet");

            var dataStartOffset = baseOffset + offset;
            if (DecryptUntil < offset)
            {
                PacketEncryption.Decrypt(inputData, dataStartOffset, 1);
            }

            Interlocked.Exchange(ref _decryptSeq, 0);

            return inputData.Span[dataStartOffset];
        }

        public byte GetDecryptedByte(Memory<byte> inputData, int offset)
        {
            if (Interlocked.Exchange(ref _decryptSeq, 1) == 1)
                _logger.Warning("Decrypting out of order packet");

            if (DecryptUntil < offset)
            {
                PacketEncryption.Decrypt(inputData, 0, 1);
            }

            Interlocked.Exchange(ref _decryptSeq, 0);

            return inputData.Span[0];
        }

        public int GetDecryptedOpcode(PacketBuffer packetBuffer, int baseOffset, int offset)
        {
            var inputData = packetBuffer.GetBuffer();
            var dataStartOffset = baseOffset + offset;

            if (DecryptUntil < offset + 4)
            {
                PacketEncryption.Decrypt(inputData, dataStartOffset, 4);
            }

            return BinaryPrimitives.ReadInt32LittleEndian(inputData.Span[dataStartOffset..]);
        }

        public int GetDecryptedOpcode(Memory<byte> inputData, int offset)
        {
            if (DecryptUntil < offset + 4)
            {
                PacketEncryption.Decrypt(inputData, 0, 4);
            }

            return BinaryPrimitives.ReadInt32LittleEndian(inputData.Span[..4]);
        }

        public int GetDecryptedOpcode(Memory<byte> inputData)
        {
            if (DecryptUntil < inputData.Length)
            {
                PacketEncryption.Decrypt(inputData, 0, inputData.Length);
            }

            return BinaryPrimitives.ReadInt32LittleEndian(inputData.Span);
        }
    }
}