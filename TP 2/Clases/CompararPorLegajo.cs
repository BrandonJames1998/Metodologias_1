using System;

namespace TP_2
{
	public class CompararPorLegajo : IEstrategiaAlumno
	{
		public bool sosIgual(Alumno alu1, Alumno alu2)
		{
			return alu1.getLegajo() == alu2.getLegajo();
		}
		
		public bool sosMenor(Alumno alu1, Alumno alu2)
		{
			return alu1.getLegajo() < alu2.getLegajo();
		}
		
		public bool sosMayor(Alumno alu1, Alumno alu2)
		{
			return alu1.getLegajo() > alu2.getLegajo();
		}
	}
}
