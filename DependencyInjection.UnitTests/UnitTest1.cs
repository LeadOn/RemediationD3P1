//-----------------------------------------------------------------------
// <copyright file="UnitTest1.cs" company="DIIAGE">
//     Copyright (c) Virot Valentin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace DependencyInjection.UnitTests
{
    using DependencyInjection.ClassLibrary;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Defines the <see cref="UnitTest1" />.
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// The TestMethod1.
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            // Creating service collection
            var services = new DependencyInjectionServiceCollection();

            //services.RegisterSingleton<IGuidGenerator, GuidGenerator>();

            //services.RegisterSingleton<RandomGuidGenerator>();
            //services.RegisterTranscient<RandomGuidGenerator>();
            //services.RegisterSingleton(new RandomGuidGenerator());

            //services.RegisterTranscient<ISomeService, SomeServiceOne>();
            //services.RegisterSingleton<IRandomGuidProvider, RandomGuidProvider>();

            var container = services.GenerateContainer();
        }
    }
}
