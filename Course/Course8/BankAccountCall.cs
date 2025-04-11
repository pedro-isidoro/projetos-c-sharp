using System;
using System.Globalization;
using Course8.BankAccountEntities;
using Course8.BankAccountEntities.Exceptions;

namespace Course8
{
    internal class BankAccountCall
    {
        public void Call()
        {
            try
            {
                Console.WriteLine("Enter account Data: ");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Account account = new Account(number, holder, balance, withdrawLimit);
                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account.WithDraw(amount);
                Console.WriteLine();
                Console.WriteLine("New balance: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (DomainException e)
            {
                Console.WriteLine("Domain exception: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format exception: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
            finally{
                Console.WriteLine("Thank you for using our services!");
            }
        }
    }
}
