//-----------------------------------------------------------------------
// <copyright file="TestSingleton.cs" company="DIIAGE">
//     Copyright (c) Virot Valentin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Singleton.ClassLibrary
{
    /// <summary>
    /// Defines the <see cref="TestSingleton" />.
    /// </summary>
    public class TestSingleton
    {
        /// <summary>
        /// Defines the lock object, to see if a thread is already using this instance.
        /// </summary>
        private static readonly object Lock = new object();

        /// <summary>
        /// Defines the singleton instance.
        /// </summary>
        private static TestSingleton instance;

        /// <summary>
        /// Prevents a default instance of the <see cref="TestSingleton"/> class from being created.
        /// </summary>
        private TestSingleton()
        {
        }

        /// <summary>
        /// Gets singleton instance.
        /// </summary>
        /// <returns>The <see cref="TestSingleton"/>.</returns>
        public static TestSingleton GetInstance()
        {
            // If the instance doesn't exists
            if (instance == null)
            {
                // If the instance is locked by a thread
                lock (Lock)
                {
                    // If the instance doesn't exists
                    if (instance == null)
                    {
                        // Creating instance
                        instance = new TestSingleton();
                    }
                }
            }

            return instance;
        }
    }
}
