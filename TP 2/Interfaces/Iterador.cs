using System;

namespace TP_2
{
	public interface Iterador
	{
		void primero(); 
		void siguiente(); 
		bool fin(); 
		Comparable actual();
	}
}
