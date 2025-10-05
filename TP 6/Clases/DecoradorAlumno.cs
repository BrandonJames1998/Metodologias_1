using System;

namespace TP_6
{
	public abstract class DecoradorAlumno: IAlumno
	{
		protected IAlumno alumno;

	    public DecoradorAlumno(IAlumno alumno)
	    {
	        this.alumno = alumno;
	    }
	    
		public virtual string getNombre()
		{
			return alumno.getNombre();
		}
	    public virtual int getLegajo()
	    {
	    	return alumno.getLegajo();
	    }
	    public virtual int getCalificacion()
	    {
	    	return alumno.getCalificacion();
	    }
	    public virtual string mostrarCalificacion()
	    {
	    	return alumno.mostrarCalificacion();
		}
	    public virtual int responderPregunta(int pregunta)
	    {
	    	return this.alumno.responderPregunta(pregunta);
	    }
	    public void setCalificacion(int nota)
	    {
	    	alumno.setCalificacion(nota);
	    }
	    public bool sosIgual(Comparable otro)
	    {
	    	return this.alumno.sosIgual(((DecoradorAlumno)otro).alumno);
	    }
        public bool sosMenor(Comparable otro)
        {
        	return this.alumno.sosMenor(((DecoradorAlumno)otro).alumno);
        }
        public bool sosMayor(Comparable otro)
        {
        	return this.alumno.sosMayor(((DecoradorAlumno)otro).alumno);
        }
        
        public void setNombre(string nombre)
        {
        	alumno.setNombre(nombre);
        }
	}
}
