using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinaryDataSerialization.Test.Misc
{
    [TestClass]
    public class SkipableTests : TestBase
    {
        [TestMethod]
        public void SkipTest()
        {
            var actual = Deserialize<SkipableContainerClass>(new byte[0]);
            Assert.IsNull(actual.Skipable);
        }
    }
}
