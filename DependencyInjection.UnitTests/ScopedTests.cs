//-----------------------------------------------------------------------
// <copyright file="ScopedTests.cs" company="DIIAGE">
//     Copyright (c) Virot Valentin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace DependencyInjection.UnitTests
{
    using System.Reflection;
    using DependencyInjection.ClassLibrary;
    using DependencyInjection.UnitTests.Classes;
    using DependencyInjection.UnitTests.Implementations;
    using DependencyInjection.UnitTests.Interfaces;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Defines the <see cref="ScopedTests" />.
    /// </summary>
    [TestClass]
    public class ScopedTests
    {
        /// <summary>
        /// DI Service collection
        /// </summary>
        private DependencyInjectionServiceCollection services;

        /// <summary>
        /// DI Container
        /// </summary>
        private DependencyInjectionContainer container;

        /// <summary>
        /// Initializes a new instance of the <see cref="ScopedTests" /> class.
        /// </summary>
        public ScopedTests()
        {
            // Creating service collection
            this.services = new DependencyInjectionServiceCollection();

            // First way to register a Transient
            this.services.RegisterTransient<RandomGuidGenerator>();

            // Second way to register a Transient
            this.services.RegisterScoped<IGuidGenerator, GuidGeneratorImplementation>();

            // Generating dependency injection container
            this.container = this.services.GenerateContainer();
        }

        /// <summary>
        /// Tests first way of instantiating a Scoped.
        /// </summary>
        [TestMethod]
        public void TestScoped()
        {
            // Getting current scope
            var mb = MethodBase.GetCurrentMethod();
            var scope = mb.ReflectedType.FullName + "." + mb.Name;

            // If scope is correctly registered, it should return the same GUID.
            var service1 = this.container.GetService<IGuidGenerator>(scope);
            var guid1 = service1.GetGuid();
            var service2 = this.container.GetService<IGuidGenerator>(scope);
            var guid2 = service2.GetGuid();

            Assert.AreEqual(guid1, guid2);

            // Simulating switching scope
            var service3 = this.container.GetService<IGuidGenerator>(scope + "1");
            var guid3 = service3.GetGuid();

            // If we got two scoped services, GUIDs should not be the same
            Assert.AreNotEqual(guid3, guid2);

            // Getting new instance of each scope, and comparing to first queried GUIDs (should be the same)
            var service4 = this.container.GetService<IGuidGenerator>(scope);
            var guid4 = service4.GetGuid();
            Assert.AreEqual(guid4, guid1);

            var service5 = this.container.GetService<IGuidGenerator>(scope + "1");
            var guid5 = service5.GetGuid();
            Assert.AreEqual(guid5, guid3);

            // But two seperates scoped GUID aren't the same
            Assert.AreNotEqual(guid4, guid5);

            // Simulating dispose of scope
            this.container.Dispose(scope);

            // Checking if it's recreated
            var service6 = this.container.GetService<IGuidGenerator>(scope);
            var guid6 = service6.GetGuid();

            // Should not be the same
            Assert.AreNotEqual(guid6, guid1);
        }
    }
}
