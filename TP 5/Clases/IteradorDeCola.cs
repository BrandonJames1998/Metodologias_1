using System;

namespace TP_5
{
	public class IteradorDeCola : Iterador
	{
	
		private Cola cola;
		private int posicion;
		
		public IteradorDeCola(Cola cola)
		{
			this.cola = cola;
			primero();
		}
		
		public void primero()
		{
			posicion = 0;
		}
		public void siguiente()
		{
			posicion ++;
		}
		public bool fin()
		{
			return posicion > cola.cuantos();
		}
		public Comparable actual()
		{
			if (posicion < 0 || posicion >= cola.cuantos()) return null;
			return cola.elementoEn(posicion);
		}
	}
}
