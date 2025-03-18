using DesignPatterns.Creational.Prototype.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Prototype.Account4_Bloch
{
    public class Account:ICloneable
    {
        protected string iban;
        protected double balance;
        protected double credit;
        protected Customer owner;
        private bool openToWithdraw;
        private bool openToPayment;
        private bool openToTransfer;


        static Account normalPrototype = new("1", 1000, 2000, new Customer("B"), true, true, true);
        static Account negativePrototype = new("2", -1000, 2000, new Customer("V"), true, true, false);
        static Account froezenPrototype = new("3", -2000, 2000, new Customer("H"), false, false, false);

        public static Account CreateNormalAccount(Customer owner, double balance)
        {
            Account account = (Account)normalPrototype.Clone();
            account.SetOwner(owner);
            account.SetBalance(balance);
            return account;
        }
        public static Account CreateNegativeAccount(Customer owner, double balance)
        {
            Account account = (Account)negativePrototype.Clone();
            account.SetOwner(owner);
            account.SetBalance(balance);
            return account;
        }
        public static Account CreateFrozenAccount(Customer owner, double balance)
        {
            Account account = (Account)froezenPrototype.Clone();
            account.SetOwner(owner);
            account.SetBalance(balance);
            return account;
        }

        private Account(string iban, double balance, double credit, Customer owner, bool openToWithdraw, bool openToPayment, bool openToTransfer)
        {
            this.iban = iban;
            this.balance = balance;
            this.credit = credit;
            this.owner = owner;
            this.openToWithdraw = openToWithdraw;
            this.openToPayment = openToPayment;
            this.openToTransfer = openToTransfer;
        }

        public string GetIban() => iban;
        public void SetIban(string iban) => this.iban = iban;
        public double GetBalance() => balance;
        public void SetBalance(double balance) => this.balance = balance;
        public void SetCredit(double credit) => this.credit = credit;
        public void SetOwner(Customer owner) => this.owner = owner;
        public void SetOpenToPayment(bool openToPayment)=> this.openToPayment = openToPayment;
        public void SetOpenToWithdraw(bool openToWithdraw) => this.openToWithdraw = openToWithdraw;
        public void SetOpenToTransfer(bool openToTransfer) => this.openToTransfer = openToTransfer;

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

}
