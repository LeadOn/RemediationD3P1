using System;
namespace AbstractFactory.ClassLibrary.iPhone
{
    public class iPhone13Product : IAbstractiPhone
    {
        public string GetDeviceModel()
        {
            return "13";
        }

        public string UsefulFunctionA()
        {
            return "Result product iPhone 13.";
        }
    }
}

