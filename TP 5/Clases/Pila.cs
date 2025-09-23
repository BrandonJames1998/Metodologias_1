using System;
using System.Collections.Generic;

namespace TP_5
{
	
	public class Pila : Coleccionable, Iterable
	{
		private List<Comparable> elementos;
		
		public Pila()
		{
			elementos = new List<Comparable>();
		}
		
		public void agregar(Comparable c)
		{
        	elementos.Add(c);
    	}
		
		public Comparable sacar() 
		{
        if (elementos.Count == 0) return null;
        Comparable ultimo = elementos[elementos.Count - 1];
        elementos.RemoveAt(elementos.Count - 1);
        return ultimo;
    	}
		
		public int cuantos()
		{
			return elementos.Count;
		}
		
		public bool contiene(Comparable c)
		{
			foreach (Comparable com in elementos)
			{
				if (com.sosIgual(c)) return true;
			}
			return false;
		}
		
		public Comparable minimo()
		{
			if (elementos.Count == 0) return null;
        	Comparable min = elementos[0];
        	foreach (Comparable e in elementos) 
        	{
            	if (e.sosMenor(min)) 
            	{
                	min = e;
            	}
        	}
        	return min;
		}
		
		public Comparable maximo()
		{
			if (elementos.Count == 0) return null;
			Comparable max = elementos[0];
        	foreach (Comparable e in elementos)
        	{
        		if (e.sosMayor(max))
        		{
        			max = e;
        		}
        	}
        	return max;
		}
		
		public Comparable elementoEn(int i)
		{
		    return elementos[i];  
		}
		
		public Iterador crearIterador()
		{
			return new IteradorDePila(this);
		}
	}
}
