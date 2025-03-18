using DesignPatterns.Creational.Prototype.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Prototype.Account3
{
    internal class AccountFactory : IFactory
    {
        public Account CreateNormalAccount()
        {
            return (Account)AccountPrototypes.prototype.Clone();
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
            Account account = (Account)AccountPrototypes.negativeprototype.Clone();
            account.SetOwner(owner);
            account.SetBalance(balance);
            return account;
        }
        public Account CreateFrozenAccount(Customer owner, double balance)
        {
            Account account = (Account)AccountPrototypes.froezenPrototype.Clone();
            account.SetOwner(owner);
            account.SetBalance(balance);
            return account;
        }

        private static class AccountPrototypes
        {
            public static Account prototype;
            public static Account negativeprototype;
            public static Account froezenPrototype;

            static AccountPrototypes() // Static constructor (Parantez kullanılabilir)
            {
                prototype = new("1", 1000, 2000, new Customer("B"), true, true, true);
                negativeprototype = new("2", -1000, 2000, new Customer("V"), true, true, false);
                froezenPrototype = new("3", -2000, 2000, new Customer("H"), false, false, false);
            }
        }
    }
}