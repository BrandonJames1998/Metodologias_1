using System;

namespace TP_6
{
	public class CompararPorLegajo : IEstrategiaComparables
	{
		public bool sosIgual(Comparable c1, Comparable c2)
		{
			return ((Alumno)c1).getLegajo() == ((Alumno)c2).getLegajo();
		}
		
		public bool sosMenor(Comparable c1, Comparable c2)
		{
			return ((Alumno)c1).getLegajo() < ((Alumno)c2).getLegajo();
		}
		
		public bool sosMayor(Comparable c1, Comparable c2)
		{
			return ((Alumno)c1).getLegajo() > ((Alumno)c2).getLegajo();
		}
	}
}
