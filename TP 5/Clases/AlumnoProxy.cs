using System;

namespace TP_5
{
	public class AlumnoProxy : IAlumno
	{
		private IAlumno alumnoReal = null;
		private string nombreProxy;
		private int opcion;
		
		public AlumnoProxy(string nombre, int opcion)
		{
			this.opcion = opcion;
			this.nombreProxy = nombre;
			Console.WriteLine("Alumno: " + this.nombreProxy + " implementado por AlumnoProxy");
		}
		
		public string getNombre()
        {
            return nombreProxy + " creado con Proxy";
        }
		
		public  int responderPregunta(int pregunta)
        {
			asegurarAlumnoReal();
			return alumnoReal.responderPregunta(pregunta);
        }
		
		public int getLegajo()
		{
			asegurarAlumnoReal();
			return alumnoReal.getLegajo();
		}
		
	    public int getCalificacion()
	    {
	    	asegurarAlumnoReal();
	    	return alumnoReal.getCalificacion();
	    }
	    
	    public string mostrarCalificacion()
	    {
	    	asegurarAlumnoReal();
	    	return alumnoReal.mostrarCalificacion();
	    }
	    
	    public void setCalificacion(int nota)
	    {
	    	asegurarAlumnoReal();
	    	alumnoReal.setCalificacion(nota);
	    }
	    
	    public void setNombre(string nombre)
	    {
	    	this.nombreProxy = nombre;
	    }
	    
	    public bool sosIgual(Comparable otro)
		{
			asegurarAlumnoReal();
		    return alumnoReal.sosIgual(((AlumnoProxy)otro).alumnoReal);
		}
		public bool sosMenor(Comparable otro)
		{
		   asegurarAlumnoReal();
		   return alumnoReal.sosMenor(((AlumnoProxy)otro).alumnoReal);
		}
		public bool sosMayor(Comparable otro)
		{
		    asegurarAlumnoReal();
		    return alumnoReal.sosMayor(((AlumnoProxy)otro).alumnoReal);
		}
	    /*
	    public bool sosIgual(Comparable otro)
		{
	    	asegurarAlumnoReal();

		    AlumnoProxy otroProxy = otro as AlumnoProxy;
		    if (otroProxy != null)
		    {
		        otroProxy.asegurarAlumnoReal();
		        return alumnoReal.sosIgual(otroProxy.alumnoReal);
		    }
		
		    return alumnoReal.sosIgual(otro);
		}
    	public bool sosMenor(Comparable otro)
    	{
    		asegurarAlumnoReal();

		    AlumnoProxy otroProxy = otro as AlumnoProxy;
		    if (otroProxy != null)
		    {
		        otroProxy.asegurarAlumnoReal();
		        return alumnoReal.sosMenor(otroProxy.alumnoReal);
		    }
		
		    return alumnoReal.sosMenor(otro);
    	}
    	public bool sosMayor(Comparable otro)
    	{
    		asegurarAlumnoReal();

		    AlumnoProxy otroProxy = otro as AlumnoProxy;
		    if (otroProxy != null)
		    {
		        otroProxy.asegurarAlumnoReal();
		        return alumnoReal.sosMayor(otroProxy.alumnoReal);
		    } 
		
		    return alumnoReal.sosMayor(otro);
    	}
    	*/
    	
    	private void asegurarAlumnoReal()  // Metodo para no repetir código
		{
		    if (alumnoReal == null)
		    {
		        alumnoReal = (IAlumno)FabricaDeComparables.crearAleatorio(opcion);
		        alumnoReal.setNombre(this.nombreProxy);
		        Console.WriteLine("Tengo que crear el alumno real. Alumno: " + nombreProxy);
		    }
		}
	}
}
