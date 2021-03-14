using System.IO;
using System.Linq;

namespace BinaryDataSerialization.Test.ItemSubtype
{
    public class CustomItem : IItemSubtype, IBinaryDataSerializable
    {
        public static readonly byte[] Data = System.Text.Encoding.ASCII.GetBytes("hello");

        public void Serialize(Stream stream, BinaryDataSerialization.Endianness endianness, BinaryDataSerializationContext serializationContext)
        {
            stream.Write(Data, 0, Data.Length);
        }

        public void Deserialize(Stream stream, BinaryDataSerialization.Endianness endianness, BinaryDataSerializationContext serializationContext)
        {
            var data = new byte[Data.Length];
            stream.Read(data, 0, data.Length);

            if (!data.SequenceEqual(Data))
                throw new InvalidDataException();
        }
    }
}
