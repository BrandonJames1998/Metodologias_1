using System;

namespace TP_6
{
	public class DecoradorNotaEnLetras : DecoradorAlumno
	{
		public DecoradorNotaEnLetras(IAlumno alumno): base(alumno) { }
		
		public override string mostrarCalificacion()
	    {
	        return alumno.getNombre() + "      " + alumno.getCalificacion() +
	        	"(" + NumeroALetras(alumno.getCalificacion()) + ")";
	    }
		
		private string NumeroALetras(int nota)
	    {
	        string[] letras = { "CERO","UNO","DOS","TRES","CUATRO","CINCO","SEIS","SIETE","OCHO","NUEVE","DIEZ" };
	        return letras[nota];
	    }
	}
	
}
