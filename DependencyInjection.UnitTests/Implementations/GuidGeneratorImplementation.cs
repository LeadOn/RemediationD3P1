//-----------------------------------------------------------------------
// <copyright file="GuidGeneratorImplementation.cs" company="DIIAGE">
//     Copyright (c) Virot Valentin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace DependencyInjection.UnitTests.Implementations
{
    using System;
    using DependencyInjection.ClassLibrary;
    using DependencyInjection.UnitTests.Interfaces;

    /// <summary>
    /// Defines the <see cref="GuidGeneratorImplementation" />.
    /// </summary>
    public class GuidGeneratorImplementation : IGuidGenerator
    {
        /// <summary>
        /// Defines a GUID.
        /// </summary>
        private readonly Guid guid = Guid.NewGuid();

        /// <summary>
        /// Returns local GUID.
        /// </summary>
        /// <returns>GUID <see cref="Guid"/>.</returns>
        public Guid GetGuid()
        {
            return this.guid;
        }
    }
}
