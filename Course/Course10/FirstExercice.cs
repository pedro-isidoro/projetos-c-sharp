using System;
using System.Globalization;
using Course10.FirstExerciceEntities;
using Course10.FirstExerciceServices;

namespace Course10
{
    internal class FirstExercice
    {
        public void Call()
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int account = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double total = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());

            Contract myContract = new Contract(account, date, total);
            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessContract(myContract, months);


            Console.WriteLine("Installments:");
            foreach (Installment installment in myContract.Installments)
            {
                Console.WriteLine(installment);
            }

        }
    }
}
