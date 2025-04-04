using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;

namespace Course3
{
    internal class FinalExerciceCall
    {
        public void Call() {
            FinalExercice account;

            Console.Write("Entre o número da conta: ");
            //finalExercice.AccountNumber = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            int number = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre o titular da conta: ");
            //finalExercice.SetAccountName (Console.ReadLine());
            string name = Console.ReadLine();
            Console.WriteLine("Haverá depósito inicial (s/n)?");
            //finalExercice.SetThereAreInitialValue(char.Parse(Console.ReadLine()));
            char answer = char.Parse(Console.ReadLine());

            if (answer == 's' || answer == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                //finalExercice.AddToTotal(double.Parse(Console.ReadLine()));
                double addValue = double.Parse(Console.ReadLine());
                account = new FinalExercice(number, name, addValue);
            }
            else
            {
                account = new FinalExercice(number, name);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(account);
            Console.WriteLine();

            Console.Write("Entre um valor para depósito:");
            account.AddToTotal(double.Parse(Console.ReadLine()));
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(account);
            Console.WriteLine();

            Console.Write("Entre um valor para saque:");
            account.RemoveFromTotal(double.Parse(Console.ReadLine()));
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(account);
            Console.WriteLine();

        }
    }
}
