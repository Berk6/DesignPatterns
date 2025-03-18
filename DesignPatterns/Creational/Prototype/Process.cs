using DesignPatterns.Creational.Prototype.Account1;
using DesignPatterns.Creational.Prototype.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Prototype
{
    public class Process
    {
        public void Process1()
        {
            Account normalAccount = new ("1", 1000, 2000, new Customer("B"), true, true, true);
            Account negativeAccount = new ("2", -1000, 2000, new Customer("V"), true, true, false);
            Account froezenAccount = new ("3", -2000, 2000, new Customer("H"), false,false,false);
        }
        public void Process2()
        {
            Account normalAccountPrototype = new ("1", 1000, 2000, new Customer("B"), true, true, true);

            
            Account negativeAccount= (Account)normalAccountPrototype.Clone();
            negativeAccount.SetBalance(-1000);
            negativeAccount.SetIban("2");
            negativeAccount.SetOwner(new Customer("V"));
            // gibi set metotları tetiklenir.
            Account froezenAccount = (Account)normalAccountPrototype.Clone();
            froezenAccount.SetBalance(-2000);
            froezenAccount.SetIban("3");
            negativeAccount.SetOwner(new Customer("H"));
        }
        //Burada clonelama işlemini yapan yapı istemci değil, factory sınıfıdır.
        public void Process3()
        {
            IFactory factory = new AccountFactory();
            Account normalAccount = factory.Create(new Customer("B"), 2000);
            normalAccount.SetCredit(5000);

            Account negativeAccount = factory.Create(new Customer("V"), 1000);
            negativeAccount.SetOpenToTransfer(false);

            Account frozenAccount = factory.Create(new Customer("H"), -1000);
            negativeAccount.SetOpenToTransfer(false);
            negativeAccount.SetOpenToWithdraw(false);
            negativeAccount.SetOpenToPayment(false);

        }
        //Karmaşık nesnenin durumlarını constructor çağrısına geçeceğimiz durum bilgisiyle halletmek yerine olabildiğince isme kaydırabiliyorsak ve Accountu çok iyi bilen tarafından tasarlanırsa diğer kullanıcıların kullanımı çok daha kolaylaşacaktır.
        public void Process4()//Account2 ve Account3 çözümü
        {
            Account2.IFactory factory = new Account2.AccountFactory();
            Account normalAccount = factory.CreateNormalAccount(new Customer("B"), 2000);
            Account negativeAccount = factory.CreateFrozenAccount(new Customer("V"), 1000);
            Account frozenAccount = factory.CreateNegativeAccount(new Customer("H"), -1000);
        }
        //Bloch çözümü uygulanmıştır, nesne içerisinde 
        public void Process6()
        {            
            Account4_Bloch.Account normalAccount = Account4_Bloch.Account.CreateNormalAccount(new Customer("B"), 2000);
            Account4_Bloch.Account negativeAccount = Account4_Bloch.Account.CreateNegativeAccount(new Customer("V"), 1000);
            Account4_Bloch.Account frozenAccount = Account4_Bloch.Account.CreateFrozenAccount(new Customer("H"), -1000);
        }
    }
}
