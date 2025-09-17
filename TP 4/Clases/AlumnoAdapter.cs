using System;
using MetodologíasDeProgramaciónI;

namespace TP_4
{
	public class AlumnoAdapter : Student
	{
		private IAlumno alumno;

        public AlumnoAdapter(IAlumno alumno)
        {
            this.alumno = alumno;
        }

        public string getName()
        {
            return alumno.getNombre();
        }

        public int yourAnswerIs(int question)
        {
        	return alumno.responderPregunta(question);
        }

        public void setScore(int score)
        {
            alumno.setCalificacion(score);
        }

        public string showResult()
        {
            return alumno.mostrarCalificacion();
        }

        public bool equals(Student student)
        {
            AlumnoAdapter otro = student as AlumnoAdapter;
            if (otro == null) return false;
            return alumno.sosIgual(otro.alumno);
        }

        public bool lessThan(Student student)
        {
            AlumnoAdapter otro = student as AlumnoAdapter;
            if (otro == null) return false;
            return alumno.sosMenor(otro.alumno);
        }

        public bool greaterThan(Student student)
        {
            AlumnoAdapter otro = student as AlumnoAdapter;
            if (otro == null) return false;
            return alumno.sosMayor(otro.alumno);
        }
    }
}
	
	