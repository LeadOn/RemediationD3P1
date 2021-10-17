using AbstractFactory.ClassLibrary;
using AbstractFactory.ClassLibrary.Android;
using AbstractFactory.ClassLibrary.iPhone;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AbstractFactory.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        private IAbstractAndroid android;
        private IAbstractiPhone iPhone;

        [TestMethod]
        public void TestMethod1()
        {
            // Taking high end devices
            ClientMethod(new HighEndPhoneFactory());

            Assert.IsInstanceOfType(android, typeof(OnePlus7Product));
            Assert.AreEqual("OnePlus", android.GetDeviceBrand());
            Assert.IsInstanceOfType(iPhone, typeof(iPhone13Product));
            Assert.AreEqual("13", iPhone.GetDeviceModel());

            // Getting Apple's model through Android interface
            Assert.AreEqual("Apple iPhone 13", android.GetCompetitorDeviceModel(iPhone));

            // Taking low end devices
            ClientMethod(new LowEndPhoneFactory());

            Assert.IsInstanceOfType(android, typeof(GooglePixel3Product));
            Assert.AreEqual("Google", android.GetDeviceBrand());
            Assert.IsInstanceOfType(iPhone, typeof(iPhoneXProduct));
            Assert.AreEqual("X", iPhone.GetDeviceModel());

            // Getting Apple's model through Android interface
            Assert.AreEqual("Apple iPhone X", android.GetCompetitorDeviceModel(iPhone));
        }

        public void ClientMethod(IPhoneFactory factory)
        {
            this.iPhone = factory.CreateiPhone();
            this.android = factory.CreateAndroid();
        }
    }
}
