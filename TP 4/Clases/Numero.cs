using System;

namespace TP_4
{
	public class Numero : Comparable
	{
		private int valor;
		
		public Numero(int num)
		{
			this.valor = num;
		}
		
		public int getValor()
		{
			return valor;
		}
		
		public bool sosIgual(Comparable c)
		{
			Numero n = ((Numero)c);
			return this.valor == n.getValor();
		}
		public bool sosMenor(Comparable c)
		{
			Numero n = ((Numero)c);
			return this.valor < n.getValor();
		}
		public bool sosMayor(Comparable c)
		{
			Numero n = ((Numero)c);
			return this.valor > n.getValor();
		}
	}
}
