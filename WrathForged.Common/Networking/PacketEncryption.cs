// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Buffers.Binary;
using System.Security.Cryptography;
using Serilog;
using WrathForged.Common.Cryptography;

namespace WrathForged.Common.Networking
{
    public class PacketEncryption
    {
        private readonly ILogger _logger;

        /// <summary>
		/// The amount of bytes to drop from the stream initially.
		///
		/// This is to resist the FMS attack.
		/// </summary>
		public const int DROP_N = 1024;

        /// <summary>
        /// This is the key the client uses to encrypt its packets
        /// This is also the key the server uses to decrypt the packets
        /// </summary>
        private static readonly byte[] _serverDecryptionKey =
            {
                0xC2, 0xB3, 0x72, 0x3C, 0xC6, 0xAE, 0xD9, 0xB5,
                0x34, 0x3C, 0x53, 0xEE, 0x2F, 0x43, 0x67, 0xCE
            };

        /// <summary>
        /// This is the key the client uses to decrypt server packets
        /// This is also the key the server uses to encrypt the packets
        /// </summary>
        private static readonly byte[] _serverEncryptionKey =
            {
                0xCC, 0x98, 0xAE, 0x04, 0xE8, 0x97, 0xEA, 0xCA,
                0x12, 0xDD, 0xC0, 0x93, 0x42, 0x91, 0x53, 0x57
            };

        // This is valid as HMAC-SHA1 transforms can be reused
        private static readonly HMACSHA1 _decryptClientDataHMAC = new(_serverDecryptionKey);

        private static readonly HMACSHA1 _encryptServerDataHMAC = new(_serverEncryptionKey);

        private int _decryptSeq;
        public int DecryptUntil { get; set; } = -1;

        /// <summary>
        /// Encrypts data sent to the client
        /// </summary>
        private readonly ARC4 _encryptServerData;

        /// <summary>
        /// Decrypts data sent from the client
        /// </summary>
        private readonly ARC4 _decryptClientData;

        public PacketEncryption(byte[] sessionKey, ILogger logger)
        {
            _logger = logger;
            var encryptHash = _encryptServerDataHMAC.ComputeHash(sessionKey);
            var decryptHash = _decryptClientDataHMAC.ComputeHash(sessionKey);

            // Used by the client to decrypt packets sent by the server
            //var decryptServerData = new ARC4(encryptHash); // CLIENT-SIDE
            // Used by the server to decrypt packets sent by the client
            _decryptClientData = new ARC4(decryptHash); // SERVER-SIDE
                                                        // Used by the server to encrypt packets sent to the client
            _encryptServerData = new ARC4(encryptHash); // SERVER-SIDE
                                                        // Used by the client to encrypt packets sent to the server
                                                        //var encryptClientData = new ARC4(decryptHash); // CLIENT-SIDE

            // Use the 2 encryption objects to generate a common starting point
            var syncBuffer = new byte[DROP_N];
            _encryptServerData.Process(syncBuffer, 0, syncBuffer.Length);

            // Use the 2 decryption objects to generate a common starting point
            syncBuffer = new byte[DROP_N];
            //decryptServerData.Process(syncBuffer, 0, syncBuffer.Length);
            _decryptClientData.Process(syncBuffer, 0, syncBuffer.Length);
        }

        public void Decrypt(Memory<byte> data, int start, int count)
        {
            _decryptClientData.Process(data, start, count);
        }

        public void Encrypt(byte[] data, int start, int count)
        {
            _encryptServerData.Process(data, start, count);
        }

        public byte GetDecryptedByte(Memory<byte> inputData, int baseOffset, int offset)
        {
            if (Interlocked.Exchange(ref _decryptSeq, 1) == 1)
                _logger.Warning("Decrypting out of order packet");

            var dataStartOffset = baseOffset + offset;
            if (DecryptUntil < offset)
            {
                Decrypt(inputData, dataStartOffset, 1);
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
                Decrypt(inputData, 0, 1);
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
                Decrypt(inputData, dataStartOffset, 4);
            }

            return BinaryPrimitives.ReadInt32LittleEndian(inputData.Span[dataStartOffset..]);
        }

        public int GetDecryptedOpcode(Memory<byte> inputData, int offset)
        {
            if (DecryptUntil < offset + 4)
            {
                Decrypt(inputData, 0, 4);
            }

            return BinaryPrimitives.ReadInt32LittleEndian(inputData.Span[..4]);
        }

        public int GetDecryptedOpcode(Memory<byte> inputData)
        {
            if (DecryptUntil < inputData.Length)
            {
                Decrypt(inputData, 0, inputData.Length);
            }

            return BinaryPrimitives.ReadInt32LittleEndian(inputData.Span);
        }
    }
}