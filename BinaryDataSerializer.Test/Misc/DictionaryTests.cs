﻿using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinaryDataSerialization.Test.Misc
{
    [TestClass]
    public class DictionaryTests : TestBase
    {
        [TestMethod]
        public void ThrowIfMemberImplementsIDictionary()
        {
#if TESTASYNC
            Assert.ThrowsException<AggregateException>(() => Roundtrip(new DictionaryMemberClass()));
#else
            Assert.ThrowsException<InvalidOperationException>(() => Roundtrip(new DictionaryMemberClass()));
#endif
        }

        [TestMethod]
        public void ThrowIfImplementsIDictionary()
        {
#if TESTASYNC
            Assert.ThrowsException<AggregateException>(() => Roundtrip(new Dictionary<string, string>()));
#else
            Assert.ThrowsException<InvalidOperationException>(() => Roundtrip(new Dictionary<string, string>()));
#endif
        }
    }
}
