using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinaryDataSerialization.Test.Misc
{
    [TestClass]
    public class IOExceptionTest
    {
        [TestMethod]
        public void ShouldThrowIOExceptionNotInvalidOperationExceptionTest()
        {
            var stream = new UnreadableStream();
            var serializer = new BinaryDataSerializer();
            Assert.ThrowsException<IOException>(() => serializer.Deserialize<int>(stream));
        }
    }
}
