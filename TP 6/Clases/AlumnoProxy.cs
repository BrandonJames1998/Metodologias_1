using System;

namespace TP_6
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
