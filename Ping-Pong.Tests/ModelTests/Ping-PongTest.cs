using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPong.Models;
using System.Collections.Generic;
using System;

namespace PingPong.Tests
{
    [TestClass]
    public class PingPongTest
    {
        //NO LONGER NEEDEDSINCE MAIN FUNCTION HAS BEEN MODIFIED FOR PING PONG
        // [TestMethod]
        // public void IsPingPongGenerator_Prints1_True()
        // {
        //     PingPongGenerator testPingPongGenerator = new PingPongGenerator();
        //     Assert.AreEqual("1", testPingPongGenerator.IsPingPongGenerator(1));
        // }
        //
        // [TestMethod]
        // public void IsPingPongGenerator_Prints12_True()
        // {
        //     PingPongGenerator testPingPongGenerator = new PingPongGenerator();
        //     Assert.AreEqual("2", testPingPongGenerator.IsPingPongGenerator(2));
        // }

        [TestMethod]
        public void IsPingPongGenerator_ReturnPing_True()
        {
            int number = 6;
            PingPongGenerator testPingPongGenerator = new PingPongGenerator();
            Assert.AreEqual(true,testPingPongGenerator.IfPing(number));
        }

        [TestMethod]
        public void IsPingPongGenerator_ReturnPong_True()
        {
            int number = 10;
            PingPongGenerator testPingPongGenerator = new PingPongGenerator();
            Assert.AreEqual(true, testPingPongGenerator.IfPong(number));
        }

        [TestMethod]
        public void IsPingPongGenerator_ReturnPingPong_True()
        {
            int number = 15;
            PingPongGenerator testPingPongGenerator = new PingPongGenerator();
            Assert.AreEqual(true, testPingPongGenerator.IfPingPong(number));
        }

        [TestMethod]
        public void IsPingPongGenerator_ReturnPingPongList_True()
        {
            int userNumber = 15;
            PingPongGenerator testPingPongGenerator = new PingPongGenerator();
            List<string> testOutput = testPingPongGenerator.PingPongString(userNumber);
            //testOutput.ForEach(i => Console.WriteLine("{0}\t", i));
            List<string> result = new List<string>{"1", "2", "Ping", "4", "Pong", "Ping", "7", "8", "Ping", "Pong", "11", "Ping", "13", "14", "PingPong"};
            CollectionAssert.AreEqual(result, testOutput);
        }

    }
}
