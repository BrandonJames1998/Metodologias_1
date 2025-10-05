using System;

namespace TP_6
{

	abstract class JuegoDeCartas
	{
		public void jugar()
		{
			mezclar();
			repartir();
			while(!hayGanador())
			{
				tomarCartas();
				descartar();
			}
		}
		
		protected abstract void mezclar();
		protected abstract void repartir();
		protected abstract void tomarCartas();
		protected abstract void descartar();
		protected abstract bool hayGanador();
	}
}
