//-----------------------------------------------------------------------
// <copyright file="ServiceDescriptor.cs" company="DIIAGE">
//     Copyright (c) Virot Valentin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace DependencyInjection.ClassLibrary
{
    using System;

    /// <summary>
    /// Defines the <see cref="ServiceDescriptor" />.
    /// </summary>
    public class ServiceDescriptor
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceDescriptor"/> class.
        /// </summary>
        /// <param name="implementation">The implementation<see cref="object"/>.</param>
        /// <param name="lifetime">The lifetime<see cref="ServiceLifetime"/>.</param>
        public ServiceDescriptor(object implementation, ServiceLifetime lifetime)
        {
            this.ServiceType = implementation.GetType();
            this.Implementation = implementation;
            this.Lifetime = lifetime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceDescriptor"/> class.
        /// </summary>
        /// <param name="serviceType">The service type<see cref="Type"/>.</param>
        /// <param name="lifetime">The lifetime<see cref="ServiceLifetime"/>.</param>
        public ServiceDescriptor(Type serviceType, ServiceLifetime lifetime)
        {
            this.ServiceType = serviceType;
            this.Lifetime = lifetime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceDescriptor"/> class.
        /// </summary>
        /// <param name="serviceType">The service type<see cref="Type"/>.</param>
        /// <param name="implementationType">The implementation type<see cref="Type"/>.</param>
        /// <param name="lifetime">The lifetime<see cref="ServiceLifetime"/>.</param>
        public ServiceDescriptor(Type serviceType, Type implementationType, ServiceLifetime lifetime)
        {
            this.ServiceType = serviceType;
            this.ImplementationType = implementationType;
            this.Lifetime = lifetime;
        }

        /// <summary>
        /// Gets the Service Type.
        /// </summary>
        public Type ServiceType { get; }

        /// <summary>
        /// Gets the Implementation Type.
        /// </summary>
        public Type ImplementationType { get; }

        /// <summary>
        /// Gets the Implementation.
        /// </summary>
        public object Implementation { get; internal set; }

        /// <summary>
        /// Gets the Lifetime.
        /// </summary>
        public ServiceLifetime Lifetime { get; }
    }
}
