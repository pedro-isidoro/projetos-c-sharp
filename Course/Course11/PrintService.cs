using System;
namespace Course11
{
	//Parametriamos como tipo T (Generics)
	public class PrintService<T>
	{
		//Assim funciona mas nao é o ideal, pois não é type safety
		//Pois object pode ser qualquer coisa
        //private object[] _values = new object[10];
        private T[] _values = new T[10];
		private int _count = 0;
		
		public void AddValue(T value)
		{
			if(_count == 10)
			{
				throw new InvalidOperationException("PrintService is full");
			}
			_values[_count] = value;
			_count++;
		}

		public T First()
		{
			if (_count == 0)
			{
				throw new InvalidOperationException("PrintService is Empty");
			}
			return _values[0];
		}

		public void Print()
		{
			Console.Write("[");
			for(int i = 0; i < _count - 1; i++)
			{
				Console.Write(_values[i] + ", ");
			}
			if(_count > 0)
			{
				Console.Write(_values[_count - 1]);
			}
			Console.Write("]");
		}
	} 	
}

