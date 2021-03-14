﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinaryDataSerialization.Test.Misc
{
    [TestClass]
    public class MiscTests : TestBase
    {
        [TestMethod]
        public async void DontFlushTooMuchTest()
        {
            var serializer = new BinaryDataSerializer();
            var expected = new DontFlushTooMuchClass();
            var stream = new UnflushableStream();

            serializer.Serialize(stream, expected);
            await serializer.SerializeAsync(stream, expected);
        }
    }
}
