using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course4
{
    internal class RefAndOutParamsCall
    {
        public void Call()
        {
            int a = 10;
            int b = 5;

            //Método com Ref
            RefAndOutParams.Triple(ref a);
            RefAndOutParams.Triple(ref b);

            Console.WriteLine(a);
            Console.WriteLine(b);

            //Método com Out, , diferente do ref, no Out não é necessário a inicialização da variável
            int c = 10;
            int result;
            RefAndOutParams.OutTriple(c, out result);
            Console.WriteLine(result);

            //Diferenças
            //A variável passsada como parâmetro ref Deve ter sido iniciada;
            //A variável passsada como parâmetro out não precisa ter sido iniciada;

            //Nota:ambos são considerados "code smells" (design ruim) e devem ser evitados.
        }
    }
}
