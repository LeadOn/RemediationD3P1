//-----------------------------------------------------------------------
// <copyright file="TransientTests.cs" company="DIIAGE">
//     Copyright (c) Virot Valentin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace DependencyInjection.UnitTests
{
    using DependencyInjection.ClassLibrary;
    using DependencyInjection.UnitTests.Classes;
    using DependencyInjection.UnitTests.Implementations;
    using DependencyInjection.UnitTests.Interfaces;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Defines the <see cref="TransientTests" />.
    /// </summary>
    [TestClass]
    public class TransientTests
    {
        /// <summary>
        /// Tests first way of instantiating a Transient.
        /// </summary>
        [TestMethod]
        public void TestTransient1()
        {
            // Creating service collection
            var services = new DependencyInjectionServiceCollection();

            // First way to register a transient
            services.RegisterTransient<RandomGuidGenerator>();

            // Generating dependency injection container
            var container = services.GenerateContainer();

            // Getting service from container
            var guidService1 = container.GetService<RandomGuidGenerator>();
            var guidService2 = container.GetService<RandomGuidGenerator>();

            // If transient is correctly registered, it should not return the same GUID.
            Assert.AreNotEqual(guidService2.RandomGuid, guidService1.RandomGuid);
        }

        /// <summary>
        /// Tests second way of instantiating a Transient.
        /// </summary>
        [TestMethod]
        public void TestTransient2()
        {
            // Creating service collection
            var services = new DependencyInjectionServiceCollection();

            // Second way to register a Transient, using interface and implementation
            services.RegisterTransient<IGuidGenerator, GuidGeneratorImplementation>();

            // Generating dependency injection container
            var container = services.GenerateContainer();

            // Getting service from container
            var guidService1 = container.GetService<IGuidGenerator>();
            var guidService2 = container.GetService<IGuidGenerator>();

            // If Transient is correctly registered, it should not return the same GUID.
            Assert.AreNotEqual(guidService2.GetGuid(), guidService1.GetGuid());
        }
    }
}
