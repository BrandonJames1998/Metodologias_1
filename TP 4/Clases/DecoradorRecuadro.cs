using System;

namespace TP_4
{
	public class DecoradorRecuadro : DecoradorAlumno
	{
		public DecoradorRecuadro(IAlumno alumno): base(alumno)
		{
		}
		
		public override string mostrarCalificacion()
	    {
	        string texto = alumno.mostrarCalificacion();
	
	        string linea = new string('*', texto.Length + 4);

	        return linea + "\n" +
	               "* " + texto + " *\n" +
	               linea;
	    }
	}
}
