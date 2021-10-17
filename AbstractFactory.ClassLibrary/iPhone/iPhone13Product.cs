//-----------------------------------------------------------------------
// <copyright file="iPhone13Product.cs" company="DIIAGE">
//     Copyright (c) Virot Valentin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace AbstractFactory.ClassLibrary.iPhone
{
    /// <summary>
    /// Defines the <see cref="iPhone13Product" />.
    /// </summary>
    public class iPhone13Product : IAbstractiPhone
    {
        /// <summary>
        /// Gets device model.
        /// </summary>
        /// <returns>Device model <see cref="string"/>.</returns>
        public string GetDeviceModel()
        {
            return "13";
        }
    }
}
