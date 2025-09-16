using System;
using MetodologíasDeProgramaciónI;

namespace TP_4
{
	public class StudentsFactory : FabricaDeAlumnos
	{
		public override Comparable crearAleatorio()
	    {
	
	        Alumno alumno = new Alumno(
	            generador.stringAleatorio(),
	            generador.numeroAleatorio(100000000), 
	            generador.numeroAleatorio(500000),    
	            generador.numeroAleatorio(10)         
	        );
	
	        IAlumno decorado = new DecoradorLegajo(alumno);
	        decorado = new DecoradorNotaEnLetras(decorado);
	        decorado = new DecoradorCondicion(decorado);
	        decorado = new DecoradorRecuadro(decorado);
	        decorado = new DecoradorRecuadroExtendido(decorado);
	
	        return new AlumnoAdapter(decorado);
	    }
	
	    public override Comparable crearPorTeclado()
	    {
	        LectorDeDatos lector = new LectorDeDatos();
	
	        Alumno alumno = new Alumno(
	            lector.stringPorTeclado(),
	            lector.numeroPorTeclado(),
	            lector.numeroPorTeclado(),
	            lector.numeroPorTeclado()
	        );
	
	        IAlumno decorado = new DecoradorLegajo(alumno);
	        decorado = new DecoradorNotaEnLetras(decorado);
	        decorado = new DecoradorCondicion(decorado);
	        decorado = new DecoradorRecuadro(decorado);
	        decorado = new DecoradorRecuadroExtendido(decorado);
	
	        return new AlumnoAdapter(decorado);
	    }
	}
}
