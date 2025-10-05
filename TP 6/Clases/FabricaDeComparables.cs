using System;

namespace TP_6
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
				case 5: fabrica = new FabricaDeAlumnosMuyEstudiosos(); break;
				case 6: fabrica = new FabricaDeAlumnosMuyEstudiososDecorados(); break;
				case 7: fabrica = new FabricaDeAlumnosDecorados(); break;
				case 8: fabrica = new FabricaDeAlumnosCompuestos(); break;
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
				case 4: fabrica = new StudentsFactory(); break;
				case 5: fabrica = new FabricaDeAlumnosMuyEstudiosos(); break;
				case 6: fabrica = new FabricaDeAlumnosMuyEstudiososDecorados(); break;
				case 7: fabrica = new FabricaDeAlumnosDecorados(); break;
				case 8: fabrica = new FabricaDeAlumnosCompuestos(); break;
			}
			return fabrica.crearPorTeclado();
		}
		
		public abstract Comparable crearAleatorio();
		public abstract Comparable crearPorTeclado();
	}
}
