using System;

namespace TP_4
{
	public interface Iterador
	{
		void primero(); 
		void siguiente(); 
		bool fin(); 
		Comparable actual();
	}
}
