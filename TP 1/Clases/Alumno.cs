using System;

namespace TP_1
{
	public class Alumno : Persona
	{
		private int legajo;
		private double promedio;
		
		public Alumno(string nom, int dni, int leg, double prom) : base(nom,dni)
		{
			this.legajo = leg;
			this.promedio = prom;
		}
		
		public int getLegajo()
		{
			return legajo;
		}
		
		public double getPromedio()
		{
			return promedio;
		}
		
		public override bool sosIgual(Comparable otro)
        {
            Alumno otroAlumno = (Alumno)otro;
            return this.promedio == otroAlumno.promedio;
        }

        public override bool sosMenor(Comparable otro)
        {
            Alumno otroAlumno = (Alumno)otro;
            return this.promedio < otroAlumno.promedio;
        }

        public override bool sosMayor(Comparable otro)
        {
            Alumno otroAlumno = (Alumno)otro;
            return this.promedio > otroAlumno.promedio;
        }
        
        public override string ToString()
        {
            return base.ToString() + ", Legajo: " + legajo + ", Promedio: " + promedio;
        }
	}
}
