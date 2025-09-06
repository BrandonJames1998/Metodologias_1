using System;

namespace TP_2
{
	public class CompararPorDni : IEstrategiaAlumno
	{
		public bool sosIgual(Alumno alu1, Alumno alu2)
		{
			return alu1.getDNI() == alu2.getDNI();
		}
		
		public bool sosMenor(Alumno alu1, Alumno alu2)
		{
			return alu1.getDNI() < alu2.getDNI();
		}
		
		public bool sosMayor(Alumno alu1, Alumno alu2)
		{
			return alu1.getDNI() > alu2.getDNI();
		}
	}
}
