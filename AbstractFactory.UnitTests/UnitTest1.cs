//-----------------------------------------------------------------------
// <copyright file="UnitTest1.cs" company="DIIAGE">
//     Copyright (c) Virot Valentin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace AbstractFactory.UnitTests
{
    using AbstractFactory.ClassLibrary;
    using AbstractFactory.ClassLibrary.Android;
    using AbstractFactory.ClassLibrary.iPhone;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Defines the <see cref="UnitTest1" />.
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Defines the android device interface.
        /// </summary>
        private IAbstractAndroid android;

        /// <summary>
        /// Defines the iPhone device interface.
        /// </summary>
        private IAbstractiPhone iPhone;

        /// <summary>
        /// Testing abstract factory design pattern.
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            // Taking high end devices
            this.ClientMethod(new HighEndPhoneFactory());

            Assert.IsInstanceOfType(this.android, typeof(OnePlus7Product));
            Assert.AreEqual("OnePlus", this.android.GetDeviceBrand());
            Assert.IsInstanceOfType(this.iPhone, typeof(iPhone13Product));
            Assert.AreEqual("13", this.iPhone.GetDeviceModel());

            // Getting Apple's model through Android interface
            Assert.AreEqual("Apple iPhone 13", this.android.GetCompetitorDeviceModel(this.iPhone));

            // Taking low end devices
            this.ClientMethod(new LowEndPhoneFactory());

            Assert.IsInstanceOfType(this.android, typeof(GooglePixel3Product));
            Assert.AreEqual("Google", this.android.GetDeviceBrand());
            Assert.IsInstanceOfType(this.iPhone, typeof(iPhoneXProduct));
            Assert.AreEqual("X", this.iPhone.GetDeviceModel());

            // Getting Apple's model through Android interface
            Assert.AreEqual("Apple iPhone X", this.android.GetCompetitorDeviceModel(this.iPhone));
        }

        /// <summary>
        /// The ClientMethod.
        /// </summary>
        /// <param name="factory">The factory<see cref="IPhoneFactory"/>.</param>
        public void ClientMethod(IPhoneFactory factory)
        {
            this.iPhone = factory.CreateiPhone();
            this.android = factory.CreateAndroid();
        }
    }
}
