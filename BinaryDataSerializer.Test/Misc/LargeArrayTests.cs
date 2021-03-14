using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinaryDataSerialization.Test.Misc
{
    [TestClass]
    public class LargeArrayTests
    {
        [TestMethod]
        public void LargeArrayTest()
        {
            var ser = new BinaryDataSerializer();
            var data = new byte[65536 * sizeof(int) * 2];

            ser.Deserialize<IntArray64K>(data);

            using (var ms = new MemoryStream(data))
            {
                ser.Deserialize<IntArray64K>(ms);
            }
        }
    }
}
