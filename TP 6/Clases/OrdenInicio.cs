using System;

namespace TP_6
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
