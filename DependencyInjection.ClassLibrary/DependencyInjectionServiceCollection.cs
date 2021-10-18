//-----------------------------------------------------------------------
// <copyright file="DependencyInjectionServiceCollection.cs" company="DIIAGE">
//     Copyright (c) Virot Valentin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace DependencyInjection.ClassLibrary
{
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="DependencyInjectionServiceCollection" />.
    /// </summary>
    public class DependencyInjectionServiceCollection
    {
        /// <summary>
        /// Defines the service descriptors.
        /// </summary>
        private List<ServiceDescriptor> serviceDescriptors = new List<ServiceDescriptor>();

        /// <summary>
        /// Register a singleton.
        /// </summary>
        /// <typeparam name="TService">Service to instantiate.</typeparam>
        public void RegisterSingleton<TService>()
        {
            this.serviceDescriptors.Add(new ServiceDescriptor(typeof(TService), ServiceLifetime.Singleton));
        }

        /// <summary>
        /// Register a singleton.
        /// </summary>
        /// <typeparam name="TService">Service to instantiate.</typeparam>
        /// <param name="implementation">Service implementation<see cref="TService"/>.</param>
        public void RegisterSingleton<TService>(TService implementation)
        {
            this.serviceDescriptors.Add(new ServiceDescriptor(implementation, ServiceLifetime.Singleton));
        }

        /// <summary>
        /// Register a singleton.
        /// </summary>
        /// <typeparam name="TService">Service to instantiate.</typeparam>
        /// <typeparam name="TImplementation">Service implementation.</typeparam>
        public void RegisterSingleton<TService, TImplementation>()
        {
            this.serviceDescriptors.Add(new ServiceDescriptor(typeof(TService), typeof(TImplementation), ServiceLifetime.Singleton));
        }

        /// <summary>
        /// Register a transient.
        /// </summary>
        /// <typeparam name="TService">Service to instantiate.</typeparam>
        public void RegisterTransient<TService>()
        {
            this.serviceDescriptors.Add(new ServiceDescriptor(typeof(TService), ServiceLifetime.Transient));
        }

        /// <summary>
        /// Register a transient.
        /// </summary>
        /// <typeparam name="TService">Service to instantiate.</typeparam>
        /// <param name="implementation">Service implementation<see cref="TService"/>.</param>
        public void RegisterTransient<TService>(TService implementation)
        {
            this.serviceDescriptors.Add(new ServiceDescriptor(implementation, ServiceLifetime.Singleton));
        }

        /// <summary>
        /// Register a transient.
        /// </summary>
        /// <typeparam name="TService">Service to instantiate.</typeparam>
        /// <typeparam name="TImplementation">Service implementation.</typeparam>
        public void RegisterTransient<TService, TImplementation>()
        {
            this.serviceDescriptors.Add(new ServiceDescriptor(typeof(TService), typeof(TImplementation), ServiceLifetime.Transient));
        }

        /// <summary>
        /// Generates a DI Container.
        /// </summary>
        /// <returns>DI Container <see cref="DependencyInjectionContainer"/>.</returns>
        public DependencyInjectionContainer GenerateContainer()
        {
            return new DependencyInjectionContainer(this.serviceDescriptors);
        }
    }
}
