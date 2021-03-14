﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinaryDataSerialization.Test.Issues.Issue140
{
    [TestClass]
    public class Issue140Tests : TestBase
    {
        [TestMethod]
        public void Test()
        {
            var expected = new Question
            {
                Domain = new Domain()
            };

            Roundtrip(expected);
        }
    }
}
