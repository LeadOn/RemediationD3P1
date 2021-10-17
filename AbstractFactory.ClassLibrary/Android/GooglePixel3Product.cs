//-----------------------------------------------------------------------
// <copyright file="GooglePixel3Product.cs" company="DIIAGE">
//     Copyright (c) Virot Valentin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace AbstractFactory.ClassLibrary.Android
{
    using AbstractFactory.ClassLibrary.iPhone;

    /// <summary>
    /// Defines the <see cref="GooglePixel3Product" /> class.
    /// </summary>
    public class GooglePixel3Product : IAbstractAndroid
    {
        /// <summary>
        /// Gets device brand.
        /// </summary>
        /// <returns>Device brand <see cref="string"/>.</returns>
        public string GetDeviceBrand()
        {
            return "Google";
        }

        /// <summary>
        /// Gets direct competitor (here Apple)'s device model.
        /// </summary>
        /// <param name="collaborator">Competitor <see cref="IAbstractiPhone"/>.</param>
        /// <returns>Device model <see cref="string"/>.</returns>
        public string GetCompetitorDeviceModel(IAbstractiPhone collaborator)
        {
            var result = collaborator.GetDeviceModel();

            return $"Apple iPhone {result}";
        }
    }
}
