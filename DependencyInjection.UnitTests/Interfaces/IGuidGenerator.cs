//-----------------------------------------------------------------------
// <copyright file="IGuidGenerator.cs" company="DIIAGE">
//     Copyright (c) Virot Valentin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace DependencyInjection.UnitTests.Interfaces
{
    using System;

    /// <summary>
    /// Defines the <see cref="IGuidGenerator" />.
    /// </summary>
    public interface IGuidGenerator
    {
        /// <summary>
        /// Returns a GUID.
        /// </summary>
        /// <returns>GUID <see cref="Guid"/>.</returns>
        Guid GetGuid();
    }
}
