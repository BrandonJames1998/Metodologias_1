using System;

namespace TP_2
{
	public class CompararPorNombre : IEstrategiaAlumno
	{
		public bool sosIgual(Alumno alu1, Alumno alu2)
		{
			return alu1.getNombre().ToLower() == alu2.getNombre().ToLower();
		}
		
		public bool sosMenor(Alumno alu1, Alumno alu2)
		{
			return string.Compare(alu1.getNombre(), alu2.getNombre()) < 0;
		}
		
		public bool sosMayor(Alumno alu1, Alumno alu2)
		{
			return string.Compare(alu1.getNombre(), alu2.getNombre()) < 0;
		}
	}
}
