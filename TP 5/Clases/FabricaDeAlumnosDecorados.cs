using System;

namespace TP_5
{
	public class FabricaDeAlumnosDecorados : FabricaDeComparables
	{
		public override Comparable crearAleatorio()
	    {
	
	        IAlumno alumno = (IAlumno)crearAleatorio(2);
	        IAlumno decorado = new DecoradorLegajo(alumno);
	        decorado = new DecoradorNotaEnLetras(decorado);
	        decorado = new DecoradorCondicion(decorado);
	        decorado = new DecoradorRecuadro(decorado);
	        decorado = new DecoradorRecuadroExtendido(decorado);
	        return decorado;
	    }
	
	    public override Comparable crearPorTeclado()
	    {
	        IAlumno alumno = (IAlumno)crearPorTeclado(2);
	        IAlumno decorado = new DecoradorLegajo(alumno);
	        decorado = new DecoradorNotaEnLetras(decorado);
	        decorado = new DecoradorCondicion(decorado);
	        decorado = new DecoradorRecuadro(decorado);
	        decorado = new DecoradorRecuadroExtendido(decorado);
	
	        return decorado;
	    }
	}
}
