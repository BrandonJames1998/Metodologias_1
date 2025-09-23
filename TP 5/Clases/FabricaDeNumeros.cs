using System;

namespace TP_5
{
	public class FabricaDeNumeros : FabricaDeComparables
	{
		public override Comparable crearAleatorio()
		{
			return new Numero(generador.numeroAleatorio(50));
		}
		
		public override Comparable crearPorTeclado()
		{
			return new Numero(lector.numeroPorTeclado());
		}
	}
}
