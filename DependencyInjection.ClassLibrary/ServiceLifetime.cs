//-----------------------------------------------------------------------
// <copyright file="ServiceLifetime.cs" company="DIIAGE">
//     Copyright (c) Virot Valentin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace DependencyInjection.ClassLibrary
{
    /// <summary>
    /// Defines all lifetime implemented in the solution.
    /// </summary>
    public enum ServiceLifetime
    {
        /// <summary>
        /// Defines the Singleton.
        /// </summary>
        Singleton,

        /// <summary>
        /// Defines the Transient.
        /// </summary>
        Transient,

        /// <summary>
        /// Defines the Scoped.
        /// </summary>
        Scoped
    }
}
