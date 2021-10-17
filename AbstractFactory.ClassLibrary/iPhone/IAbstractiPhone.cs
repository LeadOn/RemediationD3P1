using System;
namespace AbstractFactory.ClassLibrary.iPhone
{
    // Chaque produit distinct d'une famille doit avoir une interface
    // de base.
    // Tout les variants implémenteront cette interface.
    public interface IAbstractiPhone
    {
        string GetDeviceModel();
    }
}

