using System;

namespace TP_6
{
	public class FabricaDeAlumnosMuyEstudiosos : FabricaDeComparables
	{
		public override Comparable crearAleatorio()
		{
			return new AlumnoMuyEstudioso(generador.stringAleatorio(), generador.numeroAleatorio(100000000),
			                  generador.numeroAleatorio(500000), generador.numeroAleatorio(10));
		}
		
		public override Comparable crearPorTeclado()
		{
			return new AlumnoMuyEstudioso(lector.stringPorTeclado(), lector.numeroPorTeclado(),
			                  lector.numeroPorTeclado(), lector.numeroPorTeclado());
		}
	}
}
