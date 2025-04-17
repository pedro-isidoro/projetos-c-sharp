using System;
using Course13.ActionEntities;

namespace Course13
{
	public class ActionCall
	{
        //Representa um método void que recebe zero ou mais argumentos
        //public delegate void Action();
        //public delegate void Action<in T>(T obj);
        //public delegate void Action<in T1, in T2>(T1 arg1, T2 arg2);
        //Pode ter até 16 sobrecargas

        public void Call()
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("Notebook", 80.90));

            //Obj do tipo delegate action
            //Action<Product> act = UpdatePrice;
            //ou
            //com lambda
            Action<Product> act = p => { p.Price += p.Price * 0.1; };

            //list.ForEach(UpdatePrice);
            //ou
            list.ForEach(act); 
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }

        }
        //Funcao auxiliar, funcao metodo
        static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }
    }
}

