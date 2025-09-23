using System;

namespace TP_5
{

	public interface IAlumno : Comparable
	{
		string getNombre();
	    int getLegajo();
	    int getCalificacion();
	    string mostrarCalificacion();
	    int responderPregunta(int pregunta);
        void setCalificacion(int nota);
        
        // Implementa Proxy
        void setNombre(string nombre);
	}
}
