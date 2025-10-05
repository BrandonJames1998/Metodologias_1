using System;

namespace TP_6
{
	public class IteradorDeConjunto : Iterador
	{
		private Conjunto conjunto;
		private int posicion;
		
		public IteradorDeConjunto(Conjunto conjunto)
		{
			this.conjunto = conjunto;
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
			return posicion >= conjunto.cuantos();
		}
		public Comparable actual()
		{
			if (posicion < 0 || posicion >= conjunto.cuantos()) return null;
			return conjunto.elementoEn(posicion);
		}
	}
}
