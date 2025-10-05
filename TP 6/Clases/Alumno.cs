using System;

namespace TP_6
{
	public class Alumno : Persona, IObservador, IAlumno
	{
		IEstrategiaComparables estrategia;
		private int legajo;
		private double promedio;
		private int calificacion;
		
		public Alumno(string nom, int dni, int leg, double prom) : base(nom,dni)
		{
			this.legajo = leg;
			this.promedio = prom;
			this.calificacion = 0;
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
		
		public int getCalificacion()
        {
            return calificacion;
        }

        public void setCalificacion(int calif)
        {
            this.calificacion = calif;
        }
        
        public virtual int responderPregunta(int pregunta)
        {
            GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();
        	return generador.numeroAleatorio(3); 
        }
        
        public string mostrarCalificacion()
        {
            return this.getNombre() + ": " + this.getCalificacion();
        }
		
		public override bool sosIgual(Comparable otro)
		{
			return this.estrategia.sosIgual(this, (Alumno)otro);
		}
    	public override bool sosMenor(Comparable otro)
    	{
    		return this.estrategia.sosMenor(this, (Alumno)otro);
    	}
    	public override bool sosMayor(Comparable otro)
    	{
    		return this.estrategia.sosMayor(this, (Alumno)otro);
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
