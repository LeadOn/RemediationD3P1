//-----------------------------------------------------------------------
// <copyright file="LowEndPhoneFactory.cs" company="DIIAGE">
//     Copyright (c) Virot Valentin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace AbstractFactory.ClassLibrary
{
    using AbstractFactory.ClassLibrary.Android;
    using AbstractFactory.ClassLibrary.iPhone;

    /// <summary>
    /// Defines the <see cref="LowEndPhoneFactory" />.
    /// </summary>
    public class LowEndPhoneFactory : IPhoneFactory
    {
        /// <summary>
        /// Instantiates an iPhone device.
        /// </summary>
        /// <returns>iPhone device <see cref="IAbstractiPhone"/>.</returns>
        public IAbstractiPhone CreateiPhone()
        {
            return new iPhoneXProduct();
        }

        /// <summary>
        /// Instantiates an Android device.
        /// </summary>
        /// <returns>Android device <see cref="IAbstractAndroid"/>.</returns>
        public IAbstractAndroid CreateAndroid()
        {
            return new GooglePixel3Product();
        }
    }
}
