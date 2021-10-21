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
        /// DI Service collection
        /// </summary>
        private DependencyInjectionServiceCollection services;

        /// <summary>
        /// DI Container
        /// </summary>
        private DependencyInjectionContainer container;

        /// <summary>
        /// Initializes a new instance of the <see cref="TransientTests" /> class.
        /// </summary>
        public TransientTests()
        {
            // Creating service collection
            this.services = new DependencyInjectionServiceCollection();

            // First way to register a Transient
            this.services.RegisterTransient<RandomGuidGenerator>();

            // Second way to register a Transient
            this.services.RegisterTransient<IGuidGenerator, GuidGeneratorImplementation>();

            // Generating dependency injection container
            this.container = this.services.GenerateContainer();
        }

        /// <summary>
        /// Tests first way of instantiating a Transient.
        /// </summary>
        [TestMethod]
        public void TestTransient1()
        {
            // If transient is correctly registered, it should not return the same GUID.
            Assert.AreNotEqual(this.container.GetService<RandomGuidGenerator>().RandomGuid, this.container.GetService<RandomGuidGenerator>().RandomGuid);
        }

        /// <summary>
        /// Tests second way of instantiating a Transient.
        /// </summary>
        [TestMethod]
        public void TestTransient2()
        {
            // If Transient is correctly registered, it should not return the same GUID.
            Assert.AreNotEqual(this.container.GetService<IGuidGenerator>().GetGuid(), this.container.GetService<IGuidGenerator>().GetGuid());
        }
    }
}
