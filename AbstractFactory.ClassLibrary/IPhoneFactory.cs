using AbstractFactory.ClassLibrary.Android;
using AbstractFactory.ClassLibrary.iPhone;
using System;

namespace AbstractFactory.ClassLibrary
{
    // Sert à déclarer un set de méthodes qui permettent de retourner
    // les différents produits abtraits.
    // Normalement, les produits retournés ici peuvent collaborer ensemble,
    // car ils ne sont que des variants de la même base
    public interface IPhoneFactory
    {
        IAbstractiPhone CreateiPhone();
        IAbstractAndroid CreateAndroid();
    }
}

