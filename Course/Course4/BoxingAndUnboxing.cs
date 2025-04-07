using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course4
{
    internal class BoxingAndUnboxing
    {
        //Boxing
        //É o processo de conversão de um objeto tipo valor para um objeto tipo referência compatível
        //int x = 20; - Armazena seu valor na Stack
        //object obj = x; - Assim ele vira uma referência, e armazena o valor no Heap

        //Unbixing
        //É o processo de conversão de um objeto tipo referência para um objeto tipo valor compatível
        //int x = 20;
        //object obj = x;
        //int y = (int) obj; - Caso obj seja compativel com int, ele faz o casting(conversão),  e armazena o valor
        //de y na Stack
    }
}
