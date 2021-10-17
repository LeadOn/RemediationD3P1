using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Singleton.ClassLibrary;

namespace Singleton.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            TestSingleton s1 = TestSingleton.GetInstance();   
            TestSingleton s2 = TestSingleton.GetInstance();

            Assert.AreEqual(s2, s1);
        }
    }
}

