using System;
using System.Collections.Generic;

namespace TP_3
{
	public class Conjunto : Coleccionable, Iterable
	{
		List<Comparable> elementos;
		
		public Conjunto()
		{
			elementos = new List<Comparable>();
		}
		
		public void agregar(Comparable elemento)
		{
			if(!Pertenece(elemento))
			{
				elementos.Add(elemento);
			}
		}
		
		public bool Pertenece(Comparable elemento)
		{
			foreach(Comparable elem in elementos)
			{
				if(elem.sosIgual(elemento))
				{
					return true;
				}
			}
			return false;
		}
		
		public int cuantos()
		{
			return elementos.Count;
		}
		public Comparable minimo()
		{
			if (elementos.Count == 0) return null;
            Comparable min = elementos[0];
            foreach (Comparable elem in elementos)
            {
                if (elem.sosMenor(min))
                    min = elem;
            }
            return min;
		}
		public Comparable maximo()
		{
			if (elementos.Count == 0) return null;
            Comparable max = elementos[0];
            foreach (Comparable elem in elementos)
            {
                if (elem.sosMayor(max))
                    max = elem;
            }
            return max;
		}
		public bool contiene(Comparable c)
		{
			return Pertenece(c);
		}
		
		public Comparable elementoEn(int i)
		{
		    return elementos[i];  
		}
		
		public Iterador crearIterador()
		{
			return new IteradorDeConjunto(this);
		}
	}
}
