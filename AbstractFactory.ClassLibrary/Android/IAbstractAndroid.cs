using AbstractFactory.ClassLibrary.iPhone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.ClassLibrary.Android
{
    public interface IAbstractAndroid
    {
        string GetDeviceBrand();

        // Pour collaborer
        string GetCompetitorDeviceModel(IAbstractiPhone collaborator);
    }
}
