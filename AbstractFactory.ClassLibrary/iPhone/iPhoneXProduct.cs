//-----------------------------------------------------------------------
// <copyright file="iPhoneXProduct.cs" company="DIIAGE">
//     Copyright (c) Virot Valentin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace AbstractFactory.ClassLibrary.iPhone
{
    /// <summary>
    /// Defines the <see cref="iPhoneXProduct" />.
    /// </summary>
    public class iPhoneXProduct : IAbstractiPhone
    {
        /// <summary>
        /// Gets device model.
        /// </summary>
        /// <returns>Device model <see cref="string"/>.</returns>
        public string GetDeviceModel()
        {
            return "X";
        }
    }
}
