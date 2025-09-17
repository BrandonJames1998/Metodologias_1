using System;

namespace TP_4
{

	public interface IAlumno : Comparable
	{
		string getNombre();
	    int getLegajo();
	    int getCalificacion();
	    string mostrarCalificacion();
	    int responderPregunta(int pregunta);
        void setCalificacion(int nota);
	}
}
