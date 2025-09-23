using System;

namespace TP_5
{
	public interface IObservado
	{
		void agregarObservador(IObservador o);
        void quitarObservador(IObservador o);
        void notificar();
	}
}
