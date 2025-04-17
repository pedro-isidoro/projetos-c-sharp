
using System;
using Course13.DelegatesServices;
namespace Course13
{
	public class DelegatesCall
	{
		//declaracao
		delegate double BinaryNumericOperation(double n1, double n2);
		public void Call()
		{
			//É uma referência (com type safety) para um ou mais métodos
			//É um tipo referência

			//Uso Comum:
			//Comunicação entre objetos de forma flexível e extensível (eventos/callbacks)
			//Parametrização de operações por métodos (programação funcional)

			//Pré-definidos
			//Action
			//Func
			//Predicate

			double a = 10;
			double b = 12;

            //double sumResult = CalculationService.Sum(a, b);
            //double maxResult = CalculationService.Max(a, b);
            double squareResultA = CalculationService.Square(a);
			double squareResultB = CalculationService.Square(b);

			BinaryNumericOperation resultSum = CalculationService.Sum;
            BinaryNumericOperation resultMax = CalculationService.Max;

            //double sumResult = resultSum(a, b);
            double sumResult = resultSum.Invoke(a, b);
            double maxResult = resultMax(a, b);

            Console.WriteLine($"sumResult: {sumResult}");
			Console.WriteLine($"maxResult: {maxResult}");
			Console.WriteLine($"squareResultA: {squareResultA}");
			Console.WriteLine($"squareResultB: {squareResultB}");

		}
	}
}

