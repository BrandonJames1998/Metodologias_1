using System;

namespace TP_5
{
	public class OrdenInicio : IOrdenEnAula1
	{
		private Aula aula;
		
		public OrdenInicio(Aula a)
		{
			this.aula = a;
		}
		
		public void ejecutar()
		{
			aula.comenzar();
		}
	}
}
