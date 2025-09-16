using System;

namespace TP_4
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
	    	Random rnd = new Random();
            return rnd.Next(1, 4);
	    }
	    public void setCalificacion(int nota)
	    {
	    	alumno.setCalificacion(nota);
	    }
	    public bool sosIgual(IAlumno otro)
	    {
	    	return alumno.sosIgual(otro);
	    }
        public bool sosMenor(IAlumno otro)
        {
        	return alumno.sosMenor(otro);
        }
        public bool sosMayor(IAlumno otro)
        {
        	return alumno.sosMayor(otro);
        }
	}
}
