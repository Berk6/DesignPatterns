using DesignPatterns.Creational.Prototype.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Prototype.Account1
{
    internal class AccountFactory : IFactory
    {
        //1000tane bile Account Factory oluşturulsa bile tek bir prototip yeteceği için static ile işaretlendi.
        private Account prototype = new("1", 1000, 2000, new Customer("B"), true, true, true);
        public Account Create()
        {
            return (Account)prototype.Clone();
        }

        public Account Create(Customer owner, double balance)
        {
           Account account= (Account)prototype.Clone();
            account.SetOwner(owner);
            account.SetBalance(balance);
            return account;
        }
    }
}
