using System.Collections.Generic;
using System.IO;

namespace BinaryDataSerialization.Test.Issues.Issue140
{
    public class Domain : IBinaryDataSerializable, IDomain
    {
        [Ignore]
        public List<ILabel> Labels { get; }

        [Ignore]
        public string Name => ToString();

        public void Serialize(Stream stream, BinaryDataSerialization.Endianness endianness, BinaryDataSerializationContext context)
        {
            //Code
        }

        public void Deserialize(Stream stream, BinaryDataSerialization.Endianness endianness, BinaryDataSerializationContext context)
        {
            //Code
        }

    }
}
