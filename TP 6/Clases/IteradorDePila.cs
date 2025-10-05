using System;

namespace TP_6
{
	public class IteradorDePila : Iterador
	{
		private Pila pila;
		private int posicion;
		
		public IteradorDePila(Pila pila)
		{
			this.pila = pila;
			primero();
		}
		
		public void primero()
		{
			posicion = pila.cuantos() -1;
		}
			
		public void siguiente()
		{
			posicion --;
		}
			
		public bool fin()
		{
			return posicion < 0;
		}
			
		public Comparable actual()
		{
			if (posicion < 0 || posicion >= pila.cuantos()) return null;
			return pila.elementoEn(posicion);
		}
		
	}
}
