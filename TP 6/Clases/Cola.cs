using System;
using System.Collections.Generic;

namespace TP_6
{
	public class Cola : Coleccionable, Iterable, IOrdenable
	{
		private List<Comparable> elementos;
		private IOrdenEnAula1 ordenInicio;
        private IOrdenEnAula2 ordenLlegaAlumno;
        private IOrdenEnAula1 ordenAulaLlena;
		
		public Cola()
		{
			elementos = new List<Comparable>();
		}
		
		public void agregar(Comparable c) 
		{
        	if (elementos.Count == 0 && ordenInicio != null)
            {
                ordenInicio.ejecutar();
            }

            elementos.Add(c);

            if (ordenLlegaAlumno != null)
            {
                ordenLlegaAlumno.ejecutar(c);
            }

            if (elementos.Count == 40 && ordenAulaLlena != null)
            {
                ordenAulaLlena.ejecutar();
            }
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
    	
    	public void setOrdenInicio(IOrdenEnAula1 o)
    	{	
    		ordenInicio = o;
    	}
        public void setOrdenLlegaAlumno(IOrdenEnAula2 o)
        {	
        	ordenLlegaAlumno = o;
        }
        public void setOrdenAulaLlena(IOrdenEnAula1 o)
        {	
        	ordenAulaLlena = o;
        }

	}
}
