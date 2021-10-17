using System;

namespace Singleton.ClassLibrary
{
    public class TestSingleton
    {
        private TestSingleton() { }

        private static TestSingleton _instance;

        private static readonly object _lock = new object();

        public static TestSingleton GetInstance()
        {
            if(_instance == null)
            {
                lock(_lock)
                {
                    if(_instance == null)
                    {
                        _instance = new TestSingleton();
                    }
                }
            }

            return _instance;
        }
    }
}

