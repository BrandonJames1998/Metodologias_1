using System;

namespace TP_5
{
	public class CompararPorPromedio : IEstrategiaComparables
	{
		public bool sosIgual(Comparable c1, Comparable c2)
		{
			return ((Alumno)c1).getPromedio() == ((Alumno)c2).getPromedio();
		}
		
		public bool sosMenor(Comparable c1, Comparable c2)
		{
			return ((Alumno)c1).getPromedio() < ((Alumno)c2).getPromedio();
		}
		
		public bool sosMayor(Comparable c1, Comparable c2)
		{
			return ((Alumno)c1).getPromedio() > ((Alumno)c2).getPromedio();
		}
	}
}
