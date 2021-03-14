using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinaryDataSerialization.Test.Custom
{
    public class CustomSubtypeCustomClass : CustomSubtypeBaseClass, IBinaryDataSerializable
    {
        [Ignore]
        public uint Value { get; set; }

        public void Serialize(Stream stream, BinaryDataSerialization.Endianness endianness,
            BinaryDataSerializationContext serializationContext)
        {
            var boundedStream = (BoundedStream)stream;
            Assert.AreEqual(0, boundedStream.Position);
            Assert.AreEqual(100, (int)boundedStream.MaxLength.ByteCount);

            var varuint = new Varuint { Value = Value };
            varuint.Serialize(stream, endianness, serializationContext);
        }

        public void Deserialize(Stream stream, BinaryDataSerialization.Endianness endianness,
            BinaryDataSerializationContext serializationContext)
        {
            var varuint = new Varuint { Value = Value };
            varuint.Deserialize(stream, endianness, serializationContext);
            Value = varuint.Value;
        }
    }
}
