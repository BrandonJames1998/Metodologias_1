using System;

namespace TP_6
{
	public interface Iterador
	{
		void primero(); 
		void siguiente(); 
		bool fin(); 
		Comparable actual();
	}
}
