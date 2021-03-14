using System.IO;
using System.Linq;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinaryDataSerialization.Test.Custom
{
    public class CustomWithCustomAttributes : IBinaryDataSerializable
    {
        public void Serialize(Stream stream, BinaryDataSerialization.Endianness endianness, BinaryDataSerializationContext serializationContext)
        {
            var memberInfo = serializationContext.MemberInfo;
            AssertCustomAttribute(memberInfo);
        }

        public void Deserialize(Stream stream, BinaryDataSerialization.Endianness endianness, BinaryDataSerializationContext serializationContext)
        {
            var memberInfo = serializationContext.MemberInfo;
            AssertCustomAttribute(memberInfo);
        }

        private void AssertCustomAttribute(MemberInfo memberInfo)
        {
            var attributes = memberInfo.CustomAttributes;
            var customAttribute = attributes.Single();
            Assert.AreEqual(typeof(CustomAttribute), customAttribute.AttributeType);
        }
    }
}
