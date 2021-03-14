using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinaryDataSerialization.Test.Misc
{
    [TestClass]
    public class InvalidButIgnoredTests : TestBase
    {
        [TestMethod]
        public void InvalidButIgnoredTest()
        {
            Roundtrip(new InvalidButIgnoredContainerClass
            {
                InvalidButIgnored = new InvalidButIgnoredTypeClass()
            });
        }
    }
}
