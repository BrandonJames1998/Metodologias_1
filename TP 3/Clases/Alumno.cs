using System;

namespace TP_3
{
	public class Alumno : Persona, IObservador
	{
		IEstrategiaComparables estrategia;
		private int legajo;
		private double promedio;
		
		public Alumno(string nom, int dni, int leg, double prom) : base(nom,dni)
		{
			this.legajo = leg;
			this.promedio = prom;
			this.estrategia = new CompararPorLegajo();
		}
		
		public int getLegajo()
		{
			return legajo;
		}
		
		public double getPromedio()
		{
			return promedio;
		}
		
		public bool sosIgual(Alumno a)
		{
			return estrategia.sosIgual(this, a);
		}
    	public bool sosMenor(Alumno a)
    	{
    		return estrategia.sosMenor(this, a);
    	}
    	public bool sosMayor(Alumno a)
    	{
    		return estrategia.sosMayor(this, a);
    	}
        
        public override string ToString()
        {
            return base.ToString() + ", Legajo: " + legajo + ", Promedio: " + promedio;
        }
        
        public void setEstrategia(IEstrategiaComparables estrategia)
        {
        	this.estrategia = estrategia;
        }
        
        public void prestarAtencion()
        {
        	Console.WriteLine("Prestando atención...");
        }
        
        public void distraerse()
        {
        	Console.WriteLine("Mirando el celular...");
        }
        
        public void actualizar(IObservado o)
        {
        	Profesor profe = (Profesor)o;
        	if (profe.getUltimaAccion() == "hablar")
        	{
        		prestarAtencion();
        	}
        	else if (profe.getUltimaAccion() == "escribir")
            	distraerse();
        }
	}
}
