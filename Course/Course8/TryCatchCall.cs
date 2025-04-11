using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course8
{
    internal class TryCatchCall
    {
        //Bloco Try
        //Contém o código que representa a execulção normal do 
        //trecho de código que pode acarretar em uma exceção

        //Bloco Catch
        //Contém o código a ser executado caso uma exceção ocorra
        //Deve ser especificado o tipo da exceção a ser tratada
        //(upcasting é permitido)

        //Bloco Finally
        //É um bloco que contem codigo a ser executado indepen-
        //dentemente de ter ocorrido ou não uma exceção

        //Exemplo classicoÇ fechar um arquivo ou conexao de banco
        //de dados ao final do processamento.

        public void Call()
        {
            try
            {
                Console.WriteLine("Digite um número inteiro: ");
                int n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite outro número inteiro: ");
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine($"Resultado: {result}");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine($"Error! {e.Message}");
                Console.WriteLine("Division by zero is not allowed");
            }
            catch(FormatException e)
            {
                Console.WriteLine($"Error! {e.Message}");
                Console.WriteLine("Invalid number format");
            }
        }
    }
}
