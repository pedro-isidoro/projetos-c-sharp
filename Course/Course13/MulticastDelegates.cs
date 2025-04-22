using System;
using Course13.MulticastDelegatesServices;
namespace Course13
{
    delegate void BinaryNumericOperation(double n1, double n2);
    public class MulticastDelegates
	{
		public void call()
		{
            //Delegates que guardam a referência para mais de um método
            //Para adicionar uma referência, pode-se usar o operador +=
            //A chamada Invoke (ou a sintaxe reduzida) executa todos os
            //métodos na ordem em que foram adicionados
            //Seu uso faz sentido para métodos void

            double a = 10;
            double b = 12;

            BinaryNumericOperation resultSum = CalculationService.ShowSum;
            resultSum += CalculationService.ShowMax;


            resultSum.Invoke(a, b);
        }
	}
}

