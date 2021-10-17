//-----------------------------------------------------------------------
// <copyright file="IAbstractiPhone.cs" company="DIIAGE">
//     Copyright (c) Virot Valentin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace AbstractFactory.ClassLibrary.iPhone
{
    /// <summary>
    /// Defines the <see cref="IAbstractiPhone" />.
    /// </summary>
    public interface IAbstractiPhone
    {
        /// <summary>
        /// Gets device model.
        /// </summary>
        /// <returns>Device model <see cref="string"/>.</returns>
        string GetDeviceModel();
    }
}
