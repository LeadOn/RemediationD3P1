//-----------------------------------------------------------------------
// <copyright file="IPhoneFactory.cs" company="DIIAGE">
//     Copyright (c) Virot Valentin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace AbstractFactory.ClassLibrary
{
    using AbstractFactory.ClassLibrary.Android;
    using AbstractFactory.ClassLibrary.iPhone;

    /// <summary>
    /// Defines the <see cref="IPhoneFactory" />.
    /// </summary>
    public interface IPhoneFactory
    {
        /// <summary>
        /// Instantiates an iPhone device.
        /// </summary>
        /// <returns>iPhone device <see cref="IAbstractiPhone"/>.</returns>
        IAbstractiPhone CreateiPhone();

        /// <summary>
        /// Instantiates an Android device.
        /// </summary>
        /// <returns>Android device <see cref="IAbstractAndroid"/>.</returns>
        IAbstractAndroid CreateAndroid();
    }
}
