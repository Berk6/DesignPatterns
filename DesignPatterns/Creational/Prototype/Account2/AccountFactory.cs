using DesignPatterns.Creational.Prototype.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Prototype.Account2
{
    internal class AccountFactory : IFactory
    {
        //1000tane bile Account Factory oluşturulsa bile tek bir prototip yeteceği için static ile işaretlendi.
       static Account prototype = new("1", 1000, 2000, new Customer("B"), true, true, true);
       static Account negativeprototype = new("2", -1000, 2000, new Customer("V"), true, true, false);
       static Account froezenPrototype = new("3", -2000, 2000, new Customer("H"), false, false, false);

        public Account CreateNormalAccount()
        {
            return (Account)prototype.Clone();
        }
        public Account CreateNormalAccount(Customer owner, double balance)
        {
            Account account = CreateNormalAccount();
            account.SetOwner(owner);
            account.SetBalance(balance);
            return account;
        }
        public Account CreateNegativeAccount(Customer owner, double balance)
        {
            Account account = (Account)negativeprototype.Clone();
            account.SetOwner(owner);
            account.SetBalance(balance);
            return account;
        }
        public Account CreateFrozenAccount(Customer owner, double balance)
        {
            Account account = (Account)froezenPrototype.Clone();
            account.SetOwner(owner);
            account.SetBalance(balance);
            return account;
        }
    }
}