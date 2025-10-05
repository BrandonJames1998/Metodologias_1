using System;

namespace TP_6
{
	public interface IObservado
	{
		void agregarObservador(IObservador o);
        void quitarObservador(IObservador o);
        void notificar();
	}
}
