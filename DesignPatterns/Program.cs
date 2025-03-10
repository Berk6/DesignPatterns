using DesignPatterns.Creational.FactoryMethod.Factories;
using DesignPatterns.Creational.Singleton;
using System.Reflection;

for (int i = 0; i < 30; i++)
{
    BillPughSingleton singleton = BillPughSingleton.GetInstance();
    singleton.PrintName();
}

#region Singleton Reflection Denemeleri
//Class singleton olarak tasarlanmasına rağmen reflection ile birden çok nesne üretilebilmektedir, bu singleton yapısında istemediğimiz bir durumdur.
SingletonException firstInstance;
for (int i = 0; i < 15; i++)
{
    ConstructorInfo? ctor = typeof(SingletonException).GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null, Type.EmptyTypes, null);
    if (ctor != null)
    {
        SingletonException instance = (SingletonException)ctor.Invoke(null);
        instance.PrintName();
        firstInstance=SingletonException.GetInstance();
        firstInstance.PrintName();
        if(firstInstance == null)
            firstInstance = instance;
        else
            Console.WriteLine(firstInstance==instance);
    }
}
Console.WriteLine();
#endregion

