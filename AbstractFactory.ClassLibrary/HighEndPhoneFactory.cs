using AbstractFactory.ClassLibrary.Android;
using AbstractFactory.ClassLibrary.iPhone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.ClassLibrary
{
    public class HighEndPhoneFactory : IPhoneFactory
    {
        public IAbstractiPhone CreateiPhone()
        {
            return new iPhone13Product();
        }

        public IAbstractAndroid CreateAndroid()
        {
            return new OnePlus7Product();
        }
    }
}
