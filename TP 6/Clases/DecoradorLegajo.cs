using System;

namespace TP_6
{
	public class DecoradorLegajo : DecoradorAlumno
	{
		public DecoradorLegajo(IAlumno alumno) : base(alumno) { }
		
		public override string mostrarCalificacion()
	    {
	        return alumno.getNombre() + ", Legajo: " + alumno.getLegajo() + ", Calificacion: " +
	        	alumno.getCalificacion();
	    }
	}
}
