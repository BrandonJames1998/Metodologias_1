using System;

namespace TP_6
{
	public class OrdenAulaLlena : IOrdenEnAula1
	{
		private Aula aula;
		
		public OrdenAulaLlena(Aula a)
		{
			this.aula = a;
		}
		
		public void ejecutar()
		{
			aula.claseLista();
		}
	}
}
