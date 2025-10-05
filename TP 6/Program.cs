using System;

namespace TP_6
{
	class Program
	{
		public static void Main(string[] args)
		{
			Aula aula = new Aula();
			Pila pila = new Pila();
			
			pila.setOrdenInicio(new OrdenInicio(aula));
			pila.setOrdenLlegaAlumno(new OrdenLlegaAlumno(aula));
			pila.setOrdenAulaLlena(new OrdenAulaLlena(aula));
			
			llenar(pila, 8);
			llenar(pila, 8);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		static void llenar(Coleccionable c, int opcion)
		{
			for (int i = 0; i < 20; i++)
			{
				c.agregar(FabricaDeComparables.crearAleatorio(opcion));
			}
		}
	}
}