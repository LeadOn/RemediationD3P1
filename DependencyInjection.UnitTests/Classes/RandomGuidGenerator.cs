//-----------------------------------------------------------------------
// <copyright file="RandomGuidGenerator.cs" company="DIIAGE">
//     Copyright (c) Virot Valentin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace DependencyInjection.UnitTests.Classes
{
    using System;

    /// <summary>
    /// Defines the <see cref="RandomGuidGenerator" />.
    /// </summary>
    public class RandomGuidGenerator
    {
        /// <summary>
        /// Gets or sets random GUID.
        /// </summary>
        public Guid RandomGuid { get; set; } = Guid.NewGuid();
    }
}
