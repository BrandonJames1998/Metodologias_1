using System;

namespace TP_5
{
	public class LectorDeDatos
	{
		public int numeroPorTeclado()
		{
			Console.Write("Ingrese un número entero: ");
			return int.Parse(Console.ReadLine());
		}
		
		public string stringPorTeclado()
		{
			Console.Write("Ingrese un string: ");
			return Console.ReadLine();
		}
	}
}
