using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinaryDataSerialization.Test.Custom
{
    public class CustomWithContextClass : IBinaryDataSerializable
    {
        public void Serialize(Stream stream, BinaryDataSerialization.Endianness endianness,
            BinaryDataSerializationContext serializationContext)
        {
            Assert.AreEqual(typeof(CustomWithContextContainerClass), serializationContext.ParentType);
            //Assert.AreEqual("context", serializationContext.ParentContext.ParentValue);
            // TODO check root context
        }

        public void Deserialize(Stream stream, BinaryDataSerialization.Endianness endianness,
            BinaryDataSerializationContext serializationContext)
        {
            Assert.AreEqual(typeof(CustomWithContextContainerClass), serializationContext.ParentType);
        }
    }
}
