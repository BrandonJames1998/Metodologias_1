using System;

namespace TP_2
{
	public abstract class Persona : Comparable
	{
		protected string nombre;
		protected int dni;
		
		public Persona(string nom, int dni)
		{
			this.nombre = nom;
			this.dni = dni;
		}
		
		public string getNombre()
		{
			return nombre;
		}
		public int getDNI()
		{
			return dni;
		}
		
		public virtual bool sosIgual(Comparable otro)
        {
            Persona p = (Persona)otro;
            return this.dni == p.dni;
        }
		
		public virtual bool sosMenor(Comparable otro)
        {
            Persona p = (Persona)otro;
            return this.dni < p.dni;
        }
		
		public virtual bool sosMayor(Comparable otro)
        {
            Persona p = (Persona)otro;
            return this.dni > p.dni;
        }
		
		public override string ToString()
        {
            return "Nombre: " + nombre + ", DNI: " + dni;
        }
	
	}
}
