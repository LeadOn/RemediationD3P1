//-----------------------------------------------------------------------
// <copyright file="IAbstractAndroid.cs" company="DIIAGE">
//     Copyright (c) Virot Valentin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace AbstractFactory.ClassLibrary.Android
{
    using AbstractFactory.ClassLibrary.iPhone;

    /// <summary>
    /// Defines the <see cref="IAbstractAndroid" />.
    /// </summary>
    public interface IAbstractAndroid
    {
        /// <summary>
        /// Gets device brand.
        /// </summary>
        /// <returns>The <see cref="string"/>.</returns>
        string GetDeviceBrand();

        /// <summary>
        /// Gets direct competitor's device model.
        /// </summary>
        /// <param name="collaborator">Competitor <see cref="IAbstractiPhone"/>.</param>
        /// <returns>Device model <see cref="string"/>.</returns>
        string GetCompetitorDeviceModel(IAbstractiPhone collaborator);
    }
}
