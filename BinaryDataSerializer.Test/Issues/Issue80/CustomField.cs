using System.IO;

namespace BinaryDataSerialization.Test.Issues.Issue80
{
    public class CustomField : IBinaryDataSerializable
    {
        private const byte NullValue = 0xff;

        public string Value { get; set; }

        public void Serialize(Stream stream, BinaryDataSerialization.Endianness endianness, BinaryDataSerializationContext serializationContext)
        {
            if (Value == null)
            {
                stream.WriteByte(NullValue);
            }
            else
            {
                var data = System.Text.Encoding.UTF8.GetBytes(Value);
                stream.WriteByte((byte)data.Length);
                stream.Write(data, 0, data.Length);
            }
        }

        public void Deserialize(Stream stream, BinaryDataSerialization.Endianness endianness, BinaryDataSerializationContext serializationContext)
        {
            var length = stream.ReadByte();

            if (length == 0xff)
            {
                Value = null;
            }
            else
            {
                var data = new byte[length];
                stream.Read(data, 0, data.Length);
                Value = System.Text.Encoding.UTF8.GetString(data);
            }
        }
    }
}
