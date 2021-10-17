//-----------------------------------------------------------------------
// <copyright file="HighEndPhoneFactory.cs" company="DIIAGE">
//     Copyright (c) Virot Valentin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace AbstractFactory.ClassLibrary
{
    using AbstractFactory.ClassLibrary.Android;
    using AbstractFactory.ClassLibrary.iPhone;

    /// <summary>
    /// Defines the <see cref="HighEndPhoneFactory" />.
    /// </summary>
    public class HighEndPhoneFactory : IPhoneFactory
    {
        /// <summary>
        /// Returns high end iPhone.
        /// </summary>
        /// <returns>Abstract iPhone interface <see cref="IAbstractiPhone"/>.</returns>
        public IAbstractiPhone CreateiPhone()
        {
            return new iPhone13Product();
        }

        /// <summary>
        /// Returns high end Android.
        /// </summary>
        /// <returns>Abstract Android interface <see cref="IAbstractAndroid"/>.</returns>
        public IAbstractAndroid CreateAndroid()
        {
            return new OnePlus7Product();
        }
    }
}
