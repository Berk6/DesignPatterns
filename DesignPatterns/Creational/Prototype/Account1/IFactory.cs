using DesignPatterns.Creational.Prototype.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Prototype.Account1
{
    internal interface IFactory
    {
        Account Create();
        Account Create(Customer owner,double balance);
    }
}
