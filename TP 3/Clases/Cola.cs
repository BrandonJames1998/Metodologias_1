using System;
using System.Collections.Generic;

namespace TP_3
{
	public class Cola : Coleccionable, Iterable
	{
		private List<Comparable> elementos;
		
		public Cola()
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
        	Comparable primero = elementos[0];
        	elementos.RemoveAt(0);
        	return primero;
    	}
		
		public int cuantos() 
		{
        	return elementos.Count;
    	}

    	public bool contiene(Comparable c) 
    	{
        	foreach (Comparable e in elementos) 
        	{
            	if (e.sosIgual(c)) 
            	{
                	return true;
            	}
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
    		return new IteradorDeCola(this);
    	}

	}
}
