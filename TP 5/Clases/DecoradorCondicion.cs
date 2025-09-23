using System;

namespace TP_5
{
	public class DecoradorCondicion: DecoradorAlumno
	{
		public DecoradorCondicion(IAlumno alumno): base(alumno){}
		
		public override string mostrarCalificacion()
	    {
	        string estado;
	        if (alumno.getCalificacion() >= 7)
	            estado = "PROMOCIÓN";
	        else if (alumno.getCalificacion() >= 4)
	            estado = "APROBADO";
	        else
	            estado = "DESAPROBADO";
	
	        return alumno.getNombre() + alumno.getCalificacion() +
	        	"(" + estado + ")";
	    }
		
	}
}
