using System;
using System.Collections.Generic;

namespace TP_6
{
	public class Profesor : Persona, IObservado
	{
		IEstrategiaComparables estrategia;
		private List<IObservador> observadores = new List<IObservador>();
    	private string ultimaAccion;
		private int antiguedad;
		
		public Profesor(string nom, int dni, int ant) : base(nom, dni)
		{
			this.antiguedad = ant;
			this.estrategia = new CompararPorAntiguedad();
		}
		
		public int getAntiguedad()
		{
			return antiguedad;
		}
		
		public string getUltimaAccion()
		{
			return ultimaAccion;
		}
			
		public void hablarALaClase()
		{
			ultimaAccion = "hablar";
			Console.WriteLine("Hablando algún tema...");
			notificar();
		}
		
		public void escribirEnElPizarron()
		{
			ultimaAccion = "escribir";
			Console.WriteLine("Escribiendo en el pizarron...");
			notificar();
		}
		
		public bool sosIgual(Profesor p)
		{
			return estrategia.sosIgual(this, p);
		}
		public bool sosMenor(Profesor p)
		{
			return estrategia.sosMenor(this, p);
		}
		public bool sosMayor(Profesor p)
		{
			return estrategia.sosMayor(this, p);
		}
		
		public void setEstrategia(IEstrategiaComparables estrategia)
        {
        	this.estrategia = estrategia;
        }
		
		public void agregarObservador(IObservador o)
		{
			observadores.Add(o);
		}
        public void quitarObservador(IObservador o)
        {
        	observadores.Remove(o);
        }
        public void notificar()
        {
        	foreach (IObservador o in observadores)
        	{	
        		o.actualizar(this);
        	}
        }
	}
}
