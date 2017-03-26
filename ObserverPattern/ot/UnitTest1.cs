using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObserverPattern;

namespace ot
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MyTestMethod()
        {
            string name = "Anubhav";
            name = name.ToUpper();
            Assert.AreEqual("ANUBHAV", name);
        }
        [TestMethod]
        public void TestMethod1()
        {
            int a ;
            inc(out a);
            Assert.AreEqual(10, a);
        }

        [TestMethod]
        public void inc(out int a)
        {
            
            a = 10;
        }
    }
}
