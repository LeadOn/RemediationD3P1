//-----------------------------------------------------------------------
// <copyright file="UnitTest1.cs" company="DIIAGE">
//     Copyright (c) Virot Valentin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Singleton.UnitTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Singleton.ClassLibrary;

    /// <summary>
    /// Defines the <see cref="UnitTest1" />.
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Testing Singleton design pattern.
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            TestSingleton s1 = TestSingleton.GetInstance();
            TestSingleton s2 = TestSingleton.GetInstance();

            Assert.AreEqual(s2, s1);
        }
    }
}
