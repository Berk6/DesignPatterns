using DesignPatterns.Creational.Prototype.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Prototype.Account3
{
    internal interface IFactory
    {
        Account CreateNormalAccount();
        Account CreateNormalAccount(Customer owner,double balance);
        Account CreateNegativeAccount(Customer owner,double balance);
        Account CreateFrozenAccount(Customer owner,double balance);
    }
}
