using System;

namespace TP_5
{
	public class CompararPorDni : IEstrategiaComparables
	{
		public bool sosIgual(Comparable c1, Comparable c2)
		{
			return ((Persona)c1).getDNI() == ((Persona)c2).getDNI();
		}
		
		public bool sosMenor(Comparable c1, Comparable c2)
		{
			return ((Persona)c1).getDNI() < ((Persona)c2).getDNI();
		}
		
		public bool sosMayor(Comparable c1, Comparable c2)
		{
			return ((Persona)c1).getDNI() == ((Persona)c2).getDNI();
		}
	}
}
