using System;

namespace TP_4
{

	public interface IAlumno
	{
		string getNombre();
	    int getLegajo();
	    int getCalificacion();
	    string mostrarCalificacion();
	    int responderPregunta(int pregunta);
        void setCalificacion(int nota);
        bool sosIgual(IAlumno otro);
        bool sosMenor(IAlumno otro);
        bool sosMayor(IAlumno otro);
	}
}
