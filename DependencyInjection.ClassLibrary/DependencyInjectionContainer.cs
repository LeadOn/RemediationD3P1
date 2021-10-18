//-----------------------------------------------------------------------
// <copyright file="DependencyInjectionContainer.cs" company="DIIAGE">
//     Copyright (c) Virot Valentin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace DependencyInjection.ClassLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines the <see cref="DependencyInjectionContainer" />.
    /// </summary>
    public class DependencyInjectionContainer
    {
        /// <summary>
        /// Defines all service descriptors.
        /// </summary>
        private List<ServiceDescriptor> serviceDescriptors;

        /// <summary>
        /// Initializes a new instance of the <see cref="DependencyInjectionContainer"/> class.
        /// </summary>
        /// <param name="serviceDesc">Service descriptor<see cref="List{ServiceDescriptor}"/>.</param>
        public DependencyInjectionContainer(List<ServiceDescriptor> serviceDesc)
        {
            this.serviceDescriptors = serviceDesc;
        }

        /// <summary>
        /// Get service defined into the container.
        /// </summary>
        /// <param name="serviceType">Service type<see cref="Type"/>.</param>
        /// <returns>Implementation of the object<see cref="object"/>.</returns>
        public object GetService(Type serviceType)
        {
            // Getting service descriptor corresponding to given service type
            var descriptor = this.serviceDescriptors.SingleOrDefault(x => x.ServiceType == serviceType);

            // If the descriptor doesn't exist, that means that service with given type isn't registered
            if (descriptor == null)
            {
                throw new Exception($"Service of type {serviceType.Name} isn't registered.");
            }

            // If the descriptor exists, but it already has an implementation, giving it
            if (descriptor.Implementation != null)
            {
                return descriptor.Implementation;
            }

            // Getting implementation type or service type (depending on if it's an object or an interface with implementation)
            var actualType = descriptor.ImplementationType ?? descriptor.ServiceType;

            // If the type is abstract or interface (obviously not implemented)
            if (actualType.IsAbstract || actualType.IsInterface)
            {
                throw new Exception("Cannot instantiate abstract classes or interfaces.");
            }

            // Getting first constructor of the implementation / service type
            var constructorInfo = actualType.GetConstructors().First();

            // Getting ctor parameters, and instantiating it (in case interfaces are injected in constructor)
            var parameters = constructorInfo.GetParameters().Select(x => this.GetService(x.ParameterType)).ToArray();

            // Implementing instance
            var implementation = Activator.CreateInstance(actualType, parameters);

            // If it's a singleton, storing it's implementation (in order to not re-instantiate it another time)
            if (descriptor.Lifetime == ServiceLifetime.Singleton)
            {
                descriptor.Implementation = implementation;
            }

            return implementation;
        }

        /// <summary>
        /// Get service defined into the container.
        /// </summary>
        /// <typeparam name="T">Service type.</typeparam>
        /// <returns>Corresponding service <see cref="T"/>.</returns>
        public T GetService<T>()
        {
            return (T)this.GetService(typeof(T));
        }
    }
}
