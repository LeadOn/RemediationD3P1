using AbstractFactory.ClassLibrary.Android;
using AbstractFactory.ClassLibrary.iPhone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.ClassLibrary
{
    public class LowEndPhoneFactory : IPhoneFactory
    {
        public IAbstractiPhone CreateiPhone()
        {
            return new iPhoneXProduct();
        }

        public IAbstractAndroid CreateAndroid()
        {
            return new GooglePixel3Product();
        }
    }
}
