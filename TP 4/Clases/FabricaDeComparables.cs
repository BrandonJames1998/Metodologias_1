using System;

namespace TP_4
{
	public abstract class FabricaDeComparables
	{
		protected GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();
		protected LectorDeDatos lector = new LectorDeDatos();
		
		public static Comparable crearAleatorio(int opcion)
		{
			FabricaDeComparables fabrica = null;
			switch(opcion)
			{
				case 1: fabrica = new FabricaDeNumeros(); break;
				case 2: fabrica = new FabricaDeAlumnos(); break;
				case 3: fabrica = new FabricaDeProfesores(); break;
				case 4: fabrica = new StudentsFactory(); break;
			}
			return fabrica.crearAleatorio();
		}
		
		public static Comparable crearPorTeclado(int opcion)
		{
			FabricaDeComparables fabrica = null;
			switch(opcion)
			{
				case 1: fabrica = new FabricaDeNumeros(); break;
				case 2: fabrica = new FabricaDeAlumnos(); break;
				case 3: fabrica = new FabricaDeProfesores(); break;
			}
			return fabrica.crearPorTeclado();
		}
		
		public abstract Comparable crearAleatorio();
		public abstract Comparable crearPorTeclado();
	}
}
