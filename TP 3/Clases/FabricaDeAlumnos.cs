using System;

namespace TP_3
{
	public class FabricaDeAlumnos : FabricaDeComparables
	{
		public override Comparable crearAleatorio()
		{
			return new Alumno(generador.stringAleatorio(), generador.numeroAleatorio(100000000),
			                  generador.numeroAleatorio(500000), generador.numeroAleatorio(10));
		}
		
		public override Comparable crearPorTeclado()
		{
			return new Alumno(lector.stringPorTeclado(), lector.numeroPorTeclado(),
			                  lector.numeroPorTeclado(), lector.numeroPorTeclado());
		}
	}
}
