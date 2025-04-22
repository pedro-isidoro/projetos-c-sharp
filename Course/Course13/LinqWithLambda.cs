using System;
using Course13.LinqWithLambdaEntites;
using System.Collections.Generic;
using System.Linq;

namespace Course13
{
    internal class LinqWithLambda
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }
        public void Call()
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2};
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1};
            Category c3 = new Category() { Id = 3, Name = "Electronics", Tier = 1};

            List<Product> products = new List<Product>() {
                new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
                new Product() { Id = 2, Name = "Hammer", Price = 1100.0, Category = c2 },
                new Product() { Id = 3, Name = "TV", Price = 1100.0, Category = c2 },
                new Product() { Id = 4, Name = "Notebook", Price = 1100.0, Category = c2 },
                new Product() { Id = 5, Name = "Saw", Price = 1100.0, Category = c2 },
                new Product() { Id = 6, Name = "Tablet", Price = 1100.0, Category = c2 },
                new Product() { Id = 7, Name = "Camera", Price = 1100.0, Category = c2 },
                new Product() { Id = 8, Name = "Printer", Price = 1100.0, Category = c2 },
                new Product() { Id = 9, Name = "MacBook", Price = 1100.0, Category = c2 },
                new Product() { Id = 10, Name = "Sound Bar", Price = 1100.0, Category = c2 },
                new Product() { Id = 11, Name = "Level1", Price = 1100.0, Category = c2 },
            };

            //Filtra para produtos da tier 1 e com preço menor que 900
            var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0);
            Print("NAMES OF PRODUCTS FROM TOOLS", r1 );

            //Filtra para produtos da categoria ferramenta
            var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            Print("NAMES OF PRODUCTS FROM TOOLS", r2);

            //filtra os produtos que começam com C
            var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name }); //Essa "desestruturação", seria um objeto anônimo, escondido no c#
            Print("NAMES STARTED WITH 'C' AND ANONYMOUS OBJECT", r3);

            //ordena por preço e tambem caso tenham preços iguais ordena por nome
            var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            Print("TIER 1 ORDER BY PRICE THEN BY NAME", r4);
            
            //Pula 2 e pega 4
            var r5 = r4.Skip(2).Take(4);
            Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4", r5);
            
            //Caso não se tenha valor, retorna nullo == vazio
            var r6 = products.FirstOrDefault();
            Console.WriteLine("First or default test1: " + r6);
            var r7 = products.Where(p => p.Price > 3000.0).FirstOrDefault();
            Console.WriteLine("First or default test2: " + r7);
            Console.WriteLine();

            //Deve-se ter certeza de que se retorna apenas 1 resultado, para usar o single
            //Caso não se tenha valor, retorna nullo == vazio
            var r8 = products.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine("Single or default test1: " + r8);
            var r9 = products.Where(p => p.Id == 30).SingleOrDefault();
            Console.WriteLine("Single or default test2: " + r9);
            Console.WriteLine();

            //Pegando produto de maior valor
            var r10 = products.Max(p => p.Price);
            Console.WriteLine("Max price: " + r10);

            //Pegando produto de menor valor
            var r11 = products.Min(p => p.Price);
            Console.WriteLine("Min price: " + r11);

            //Mostrando a soma dos preços, dos produtos de categoria 1
            var r12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            Console.WriteLine("Category 1 Sum prices: " + r12);

            //Mostrando a média dos preços, dos produtos de categoria 1
            var r13 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
            Console.WriteLine("Category 1 Average prices: " + r13);

            //Aqui filtramos pela categoria 5 e selecionamos o preço como alvo,
            //caso seja vazio o numero de elementos pego, o valor retornado será o 0.0,
            //mas caso tenha, fará a média dos valores
            var r14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Category 5 Average prices: " + r14);

            //Reduce - Select e Aggregate (conhecido como reduce)
            var r15 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y);
            Console.WriteLine("Category 1 aggregate sum: " + r15);
            Console.WriteLine();

            var r16 = products.GroupBy(p => p.Category);
            //Como sei que seria IGrouping<Category, Product>?
            //Coloca o mouse em cima do r16, e mostrará o que o T retornará
            foreach (IGrouping<Category, Product> group in r16)
            {
                //Aqui pegamos o nome da categoria
                Console.WriteLine("Category " + group.Key.Name + ":");
                foreach (Product p in group)
                {
                    //aqui retornamos o ToString de cada produto da categoria
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }

        }
    }
}
