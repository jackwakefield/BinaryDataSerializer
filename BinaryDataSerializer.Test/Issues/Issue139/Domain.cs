using System.IO;

namespace BinaryDataSerialization.Test.Issues.Issue139
{
    public class Domain : IBinaryDataSerializable, IDomain
    {
        public byte Value { get; set; }

        public void Serialize(Stream stream, BinaryDataSerialization.Endianness endianness, BinaryDataSerializationContext serializationContext)
        {
            stream.WriteByte(5);
        }

        public void Deserialize(Stream stream, BinaryDataSerialization.Endianness endianness, BinaryDataSerializationContext serializationContext)
        {
            Value = (byte)stream.ReadByte();
        }
    }
}
