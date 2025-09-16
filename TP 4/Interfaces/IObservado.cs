using System;

namespace TP_4
{
	public interface IObservado
	{
		void agregarObservador(IObservador o);
        void quitarObservador(IObservador o);
        void notificar();
	}
}
