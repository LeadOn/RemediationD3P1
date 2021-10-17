using System;
namespace AbstractFactory.ClassLibrary.iPhone
{
    public class iPhoneXProduct : IAbstractiPhone
    {
        public string GetDeviceModel()
        {
            return "X";
        }

        public string UsefulFunctionA()
        {
            return "Result product iPhone X.";
        }
    }
}

