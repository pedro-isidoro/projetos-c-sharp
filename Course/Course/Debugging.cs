using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course1
{
    internal class Debugging
    {
        public void Debugg() {
            //Aperte a tecla F9 na linha em foco que quer colocar o breakpoint
            //F10 Para prosseguir depois do breakpoint
            //Porem nao entra passo a passo na funcao, apenas a executa
            //Se quiser ver, tera que fazer F11
            //Shift + F11 para sair do metodo em execucao
            //Shift + F5 para Parar
            Console.WriteLine("Digite 3 números: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            double resultado = Maior(n1, n2, n3);
            Console.WriteLine("Maior = " + resultado);
        }
        int Maior(int a, int b, int c)
        {
            int m;
            if (a > b && a > c)
            {
                m = a;
            }
            else if (b > c)
            {
                m = b;
            }
            else
            {
                m = c;
            }
            return m;
        }
    }
}
