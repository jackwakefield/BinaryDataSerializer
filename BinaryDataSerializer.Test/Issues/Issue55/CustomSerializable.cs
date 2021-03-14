using System;
using System.IO;

namespace BinaryDataSerialization.Test.Issues.Issue55
{
    public class CustomSerializable : IBinaryDataSerializable
    {
        [Ignore]
        public byte Value;

        public void Serialize(Stream stream, BinaryDataSerialization.Endianness endianness, BinaryDataSerializationContext serializationContext)
        {
            stream.WriteByte(Value);
        }

        public void Deserialize(Stream stream, BinaryDataSerialization.Endianness endianness, BinaryDataSerializationContext serializationContext)
        {
            var readByte = stream.ReadByte();
            if (readByte == -1) throw new EndOfStreamException();
            Value = Convert.ToByte(readByte);
        }
    }
}
