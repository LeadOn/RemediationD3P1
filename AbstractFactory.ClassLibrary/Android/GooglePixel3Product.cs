using AbstractFactory.ClassLibrary.iPhone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.ClassLibrary.Android
{
    public class GooglePixel3Product : IAbstractAndroid
    {
        public string GetDeviceBrand()
        {
            return "Google";
        }

        public string GetCompetitorDeviceModel(IAbstractiPhone collaborator)
        {
            var result = collaborator.GetDeviceModel();

            return $"Apple iPhone {result}";
        }
    }
}
