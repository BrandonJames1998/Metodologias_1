using System;

namespace TP_5
{
	public class FabricaDeProfesores : FabricaDeComparables
	{
		public override Comparable crearAleatorio()
		{
			return new Profesor(generador.stringAleatorio(), generador.numeroAleatorio(100000000),
			                  generador.numeroAleatorio(70));
		}
		
		public override Comparable crearPorTeclado()
		{
			return new Profesor(lector.stringPorTeclado(), lector.numeroPorTeclado(),
			                  lector.numeroPorTeclado());
		}
	}
}
