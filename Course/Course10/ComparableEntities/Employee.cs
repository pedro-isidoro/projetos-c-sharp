using System;
using System.Globalization;

namespace Course10.ComparableEntities
{
    internal class Employee : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        //Nesse constructor rece o funcionario em csv, e
        //ele sera responsavel por atribuir os valores nos atributos
        public Employee(string csvEmployee)
        {
            string[] vect = csvEmployee.Split(',');
            Name = vect[0];
            Salary = double.Parse(vect[1], CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return Name
                + ", "
                + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

        //Object ComparableTo retorn int por que?
        //Pois se o que veio por parametro for menor que o atual retorna um valor menor que 0. Ex: -1
        //São iguais, 0
        //Se for maior, será maior que 0. Ex: 1
        public int CompareTo(object obj)
        {
            //Proteção para caso o valor comparado não seja do tipo Employee
            if(!(obj is Employee))
            {
                throw new ArgumentException("Comparing error: argument is not an employee");
            }
            Employee other = obj as Employee;
            return Name.CompareTo(other.Name);
            //Ou
            //return Salary.CompareTo(other.Salary);
        }
    }
}
