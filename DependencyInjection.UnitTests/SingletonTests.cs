//-----------------------------------------------------------------------
// <copyright file="SingletonTests.cs" company="DIIAGE">
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
    /// Defines the <see cref="SingletonTests" />.
    /// </summary>
    [TestClass]
    public class SingletonTests
    {
        /// <summary>
        /// Tests first way of instantiating a Singleton.
        /// </summary>
        [TestMethod]
        public void TestSingleton1()
        {
            // Creating service collection
            var services = new DependencyInjectionServiceCollection();

            // First way to register a Singleton
            services.RegisterSingleton<RandomGuidGenerator>();

            // Generating dependency injection container
            var container = services.GenerateContainer();

            // Getting service from container
            var guidService1 = container.GetService<RandomGuidGenerator>();
            var guidService2 = container.GetService<RandomGuidGenerator>();

            // If singleton is correctly registered, it should return the same GUID.
            Assert.AreEqual(guidService2.RandomGuid, guidService1.RandomGuid);
        }

        /// <summary>
        /// Tests second way of instantiating a Singleton.
        /// </summary>
        [TestMethod]
        public void TestSingleton2()
        {
            // Creating service collection
            var services = new DependencyInjectionServiceCollection();

            // Second way to register a Singleton
            services.RegisterSingleton(new RandomGuidGenerator());

            // Generating dependency injection container
            var container = services.GenerateContainer();

            // Getting service from container
            var guidService1 = container.GetService<RandomGuidGenerator>();
            var guidService2 = container.GetService<RandomGuidGenerator>();

            // If singleton is correctly registered, it should return the same GUID.
            Assert.AreEqual(guidService2.RandomGuid, guidService1.RandomGuid);
        }

        /// <summary>
        /// Tests third way of instantiating a Singleton.
        /// </summary>
        [TestMethod]
        public void TestSingleton3()
        {
            // Creating service collection
            var services = new DependencyInjectionServiceCollection();

            // Third way to register a Singleton, using interface and implementation
            services.RegisterSingleton<IGuidGenerator, GuidGeneratorImplementation>();

            // Generating dependency injection container
            var container = services.GenerateContainer();

            // Getting service from container
            var guidService1 = container.GetService<IGuidGenerator>();
            var guidService2 = container.GetService<IGuidGenerator>();

            // If singleton is correctly registered, it should return the same GUID.
            Assert.AreEqual(guidService2.GetGuid(), guidService1.GetGuid());
        }
    }
}
