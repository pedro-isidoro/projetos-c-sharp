using Employeers.Entities;

namespace Employeers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SalariedEmployee employee = new SalariedEmployee()
            {
                Name = "Pedro",
                Email = "pedro.luis563@gmail.com",
                Salary = 2700
            };
            
            HourlyEmployee employee2 = new HourlyEmployee()
            {
                Name = "Eduardo",
                Email = "Eduardo.luis563@gmail.com",
                Salary = 5700
            };

            CommissionEmployee employee3 = new CommissionEmployee()
            {
                Name = "Diego",
                Email = "Diego.luis563@gmail.com",
                Salary = 2700
            };

            Console.WriteLine(employee);
            Console.WriteLine(employee2);
            Console.WriteLine(employee3);
        }
    }
}
