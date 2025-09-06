using System;

namespace TP_2
{
	public class CompararPorPromedio : IEstrategiaAlumno
	{
		public bool sosIgual(Alumno alu1, Alumno alu2)
		{
			return alu1.getPromedio() == alu2.getPromedio();
		}
		
		public bool sosMenor(Alumno alu1, Alumno alu2)
		{
			return alu1.getPromedio() < alu2.getPromedio();
		}
		
		public bool sosMayor(Alumno alu1, Alumno alu2)
		{
			return alu1.getPromedio() > alu2.getPromedio();
		}
	}
}
