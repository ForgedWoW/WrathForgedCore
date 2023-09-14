// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Collections.Concurrent;
using System.Reflection;
using WrathForged.Models.Networking;
using WrathForged.Serialization;

namespace WrathForged.Common.Networking
{
    public class WoWClientPacketOut : IDisposable
    {
        private bool _disposedValue;
        private static readonly ConcurrentDictionary<Type, MethodInfo> _serializers = new();

        public WoWClientPacketOut(PacketId packetId, int headerSize = -1)
        {
            PacketId = packetId;
            Writer = new PrimitiveWriter();
            MemoryStream = (MemoryStream)Writer.BaseStream;

            if (headerSize == -1)
                headerSize = packetId.Scope == PacketScope.Auth ? 2 : 4;

            Writer.Write(new byte[headerSize]);
        }

        public PacketId PacketId { get; }

        public PrimitiveWriter Writer { get; }

        public MemoryStream MemoryStream { get; }

        /// <summary>
        ///     We use memory to avoid copying the buffer, and manipulating the buffer in the stream directly.
        /// </summary>
        /// <returns></returns>
        public Memory<byte> GetBuffer()
        {
            // Step 1: Flush the MemoryStream to ensure all writes are completed
            MemoryStream.Flush();

            // Step 2: Get the underlying buffer without copying
            var buffer = MemoryStream.GetBuffer();

            // Step 3: Write the header to the start of the existing buffer.
            if (PacketId.Scope == PacketScope.Auth)
                WriteAuthHeader(buffer);
            else
                WriteRealmHeader(buffer);

            // Step 4: Create a Memory<byte> segment that encompasses the entire buffer (header + content).
            return new Memory<byte>(buffer, 0, buffer.Length);
        }

        private void WriteAuthHeader(byte[] buffer)
        {
            var headerSize = 4; // 1 byte for content length, 2 bytes for PacketId.Id, and 1 byte for terminator
            var contentLength = buffer.Length - headerSize;

            var span = buffer.AsSpan();
            span[0] = (byte)contentLength;
            _ = BitConverter.TryWriteBytes(span.Slice(1, 2), (ushort)PacketId.Id);
            span[3] = 0; // Zero terminator
        }

        private void WriteRealmHeader(byte[] buffer)
        {
            var span = buffer.AsSpan();
            span[0] = (byte)PacketId.Id;
            span[1] = 0;  // Zero terminator
        }

        public void WriteObject<T>(T obj)
        {
            if (obj == null)
                return;

            // Get the type of the object
            var type = obj.GetType();

            if (_serializers.TryGetValue(type, out var serializer))
            {
                // If we have a serializer for this type, use it
                _ = serializer.Invoke(null, new object[] { obj, Writer });
                return;
            }

            // Find the Serialize method which is an extension method
            var method = type.GetMethod("Serialize", new[] { type, typeof(BinaryWriter) });

            if (method != null)
            {
                _ = _serializers.TryAdd(type, method);
                _ = method.Invoke(null, new object[] { obj, Writer });
            }
            else
            {
                throw new InvalidOperationException($"Serialize method not found for type {type.FullName}");
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    Writer.Dispose();
                }

                _disposedValue = true;
            }
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}