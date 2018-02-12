using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPong;
using System.Collections.Generic;
using System;

namespace PingPong.Tests
{
    [TestClass]
    public class PingPongTest
    {
        // public void Dispose()
        // {
        //     PingPongGenerator.ClearAll();
        // }
        [TestMethod]
        public void IsPingPongGenerator_PrintsNumbers0ToUserInput_True()
        {
            PingPongGenerator testPingPongGenerator = new PingPongGenerator();
            Assert.AreEqual(true, testPingPongGenerator.IsPingPongGenerator(20));
        }
    }
}
