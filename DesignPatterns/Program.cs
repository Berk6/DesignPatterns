using DesignPatterns;

for (int i = 0; i < 30; i++)
{
    Singleton singleton= Singleton.Instance;
    singleton.PrintName();
}