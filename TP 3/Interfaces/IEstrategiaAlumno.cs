using System;

namespace TP_2
{
	public interface IEstrategiaAlumno
	{
		bool sosIgual(Alumno alu1, Alumno alu2);
		bool sosMenor(Alumno alu1, Alumno alu2);
		bool sosMayor(Alumno alu1, Alumno alu2);
		
	}
}
