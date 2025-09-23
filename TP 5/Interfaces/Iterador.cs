using System;

namespace TP_5
{
	public interface Iterador
	{
		void primero(); 
		void siguiente(); 
		bool fin(); 
		Comparable actual();
	}
}
