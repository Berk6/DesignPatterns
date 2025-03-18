using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Prototype.Models
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

        public Account(string iban, double balance, double credit, Customer owner, bool openToWithdraw, bool openToPayment, bool openToTransfer)
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
