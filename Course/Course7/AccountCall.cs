using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Course7.AccountEntities;

namespace Course7
{
    internal class AccountCall
    {
        public void Call() {
            /*
            //BusinessAccount account = new BusinessAccount(0010, "Pedro", 100.0, 500.0);
            //Console.WriteLine(account.Balance);
            //Console.WriteLine("Teste");

            //account.Balance = 200.0; // Error: Cannot assign to 'Balance' because it is read-only

            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bcc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            //Upcasting
            Account acc1 = bcc; // BusinessAccount -> Account
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0); // BusinessAccount -> Account
            Account acc3 = new SavingAccount(1004, "Anna", 0.0, 0.01); // SavingAccount -> Account

            //Downcasting
            BusinessAccount acc4 = (BusinessAccount)acc2; // Account -> BusinessAccount
            acc4.Loan(100.0);
            //acc2.Loan(100.0); // Error: Cannot access 'Loan' method because it is not defined in the base class

            //BusinessAccount acc5 = (BusinessAccount)acc3; //assim da erro de casting
            if(acc3 is BusinessAccount) //Se acc3 for uma instância de BusinessAccount, faça
            {
                //BusinessAccount acc5 = (BusinessAccount)acc3; // Account -> BusinessAccount
                //ou
                BusinessAccount acc5 = acc3 as BusinessAccount; // Account -> BusinessAccount
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }

            if(acc3 is SavingAccount)
            {
                //SavingAccount acc6 = (SavingAccount)acc3; // Account -> SavingAccount
                SavingAccount acc6 = acc3 as SavingAccount; // Account -> SavingAccount
                acc6.UpdateBalance();
                Console.WriteLine("Update!");
            }
            */

            //Isso abaixo já é um polimorfismo
            Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingAccount(1002, "Maria", 500.0, 0.01);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine(acc1.Balance); // 490.0
            Console.WriteLine(acc2.Balance); // 490.0

        }
    }
}
