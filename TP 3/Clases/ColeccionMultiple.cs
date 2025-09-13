using System;
using System.Collections.Generic;

namespace TP_3
{
	
	public class ColeccionMultiple : Coleccionable
	{
		private Coleccionable pila;
		private Coleccionable cola;
		
		public ColeccionMultiple(Coleccionable p, Coleccionable c)
		{
			this.pila = p;
			this.cola = c;
		}
		
		public int cuantos()
		{
			return pila.cuantos() + cola.cuantos();
		}
		
		public Comparable minimo()
		{
			Comparable minPila = pila.minimo();
			Comparable minCola = cola.minimo();
			
			if (minPila == null) return minCola;
            if (minCola == null) return minPila;
            
            if (minPila.sosMenor(minCola))
			{
    		return minPila;
			}
			else
			{
    			return minCola;
			}
		}
		
		public Comparable maximo()
		{
			Comparable maxPila = pila.maximo();
			Comparable maxCola = cola.maximo();
			
			if (maxPila == null) return maxCola;
            if (maxCola == null) return maxPila;
            
            if (maxPila.sosMayor(maxCola))
			{
    			return maxPila;
			}
			else
			{
    			return maxCola;
			}
			
			
		}
		
		public void agregar(Comparable c)
        {
            // No se implementa
        }
			
		public bool contiene(Comparable c)
        {
            return pila.contiene(c) || cola.contiene(c);
		}
	}
}
