﻿using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinaryDataSerialization.Test.Issues.Issue50
{
    [TestClass]
    public class Issue50Tests : TestBase
    {
        [TestMethod]
        public void RoundtripTest()
        {
            var serializer = new BinaryDataSerializer { Endianness = BinaryDataSerialization.Endianness.Big };

            var expected = new MsgHeader { PayloadType = PlcPayloadType.Value3 };

            var stream = new MemoryStream();
            serializer.Serialize(stream, expected);

            stream.Position = 0;

            var actual = serializer.Deserialize<MsgHeader>(stream);

            Assert.AreEqual(expected.PayloadType, actual.PayloadType);
        }
    }
}
