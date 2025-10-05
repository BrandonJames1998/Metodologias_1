using System;
using System.Collections.Generic;

namespace TP_6
{
	
	public class AlumnoCompuesto : IAlumno
	{
		List <IAlumno> hijos;
		
		public AlumnoCompuesto()
		{
			this.hijos = new List<IAlumno>();
		}
		
		public void agregarHijo(IAlumno a)
		{
			this.hijos.Add(a);
		}
		public void quitarHijo(IAlumno a)
		{
			this.hijos.Remove(a);
		}
		
		public string getNombre()
		{
			string nombres = "";
			foreach(IAlumno a in hijos)
			{
				nombres += a.getNombre() + "\n";
			}
			return nombres;
		}
		public int responderPregunta(int pregunta)
		{
			int[] respuestas = new int[3];

		    foreach (IAlumno a in hijos)
		    {
		        int r = a.responderPregunta(pregunta);
		        respuestas[r]++;
		    }
		
		    int maxRespuesta = 0;
		    int maxVotos = respuestas[0];
			Random rnd = new Random();
			
		    for (int i = 1; i < respuestas.Length; i++)
		    {
		        if (respuestas[i] > maxVotos)
		        {
		            maxVotos = respuestas[i];
		            maxRespuesta = i;
		        }
		        else if (respuestas[i] == maxVotos)
		        {
		            
		            if (rnd.Next(2) == 0)
		            {
		                maxRespuesta = i;
		            }
		        }
		    }		
		    return maxRespuesta;
		}
		public bool sosMenor(Comparable comparable) 
		{
			foreach(IAlumno a in hijos)
			{
				if(!a.sosMenor(comparable))
				{
					return false;
				}
			}
			return true;
		}
		public bool sosIgual(Comparable comparable)
		{
			foreach(IAlumno a in hijos)
			{
				if(a.sosIgual(comparable))
				{
					return true;
				}
			}
			return false;
		}
		public bool sosMayor(Comparable comparable) 
		{
			foreach(IAlumno a in hijos)
			{
				if(!a.sosMayor(comparable))
				{
					return false;
				}
			}
			return true;
		}		
	    
		public int getLegajo()
		{
			if (hijos.Count > 0)
			{
                return hijos[0].getLegajo();
			}
            return -1;
		}
	    public int getCalificacion()
	    {
	    	foreach(IAlumno a in hijos)
	    	{
	    		return a.getCalificacion();
	    	}
	    	return -1;
	    }
	    public string mostrarCalificacion()
	    {
	    	string resultado = "";
            foreach (IAlumno a in hijos)
            {
                resultado += a.mostrarCalificacion() + "\n";
            }
            return resultado.Trim();
	    }
	    public void setCalificacion(int nota)
	    {
	    	foreach (IAlumno a in hijos)
            {
                a.setCalificacion(nota);
            }
	    }
	    
        public void setNombre(string nombre)
        {
        	foreach (IAlumno a in hijos)
            {
                a.setNombre(nombre);
            }
        }
	}
		
}
