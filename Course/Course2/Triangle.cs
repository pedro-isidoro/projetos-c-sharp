//Importação de dependências
using System;
//Namespace da classe
namespace Course2
{
    //Nome da classe
    internal class Triangle
    {
        //O prefixo "public" indica que o atributo ou
        //método pode ser usado em outros arquivos
        public double A; //Atributos da classe
        public double B; //Atributos da classe
        public double C; //Atributos da classe

        //Metodo é uma função dentro da classe
        //doubleTipo de dado que o método retorna
        //(se o método não retorna nada, usa-se a palavra "void")
        public double Area()//Nome do Metodo e lista de parâmetros dele
        {
            //Corpo do Método
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}

//Reaproveitamento de código:
//Nós eliminamos o código repetido (cálculo da área)

//Delegação de responsabilidade:
//Quem deve ser responsável por saber como calcular a área de um triângulo é o próprio.
//A lógica do cálculo da área não deve estar em outro lugar.