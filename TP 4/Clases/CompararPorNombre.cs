using System;

namespace TP_4
{
	public class CompararPorNombre : IEstrategiaComparables
	{
		public bool sosIgual(Comparable c1, Comparable c2)
		{
			return ((Alumno)c1).getNombre().ToLower() == ((Alumno)c2).getNombre().ToLower();
		}
		
		public bool sosMenor(Comparable c1, Comparable c2)
		{
			return string.Compare(((Alumno)c1).getNombre(), ((Alumno)c2).getNombre()) < 0;
		}
		
		public bool sosMayor(Comparable c1, Comparable c2)
		{
			return string.Compare(((Alumno)c1).getNombre(), ((Alumno)c2).getNombre()) > 0;
		}
	}
}
