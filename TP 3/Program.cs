using System;
using System.Collections.Generic;

namespace TP_3
{
	class Program
	{
		public static void Main(string[] args)
		{
			/*
			Console.WriteLine("Clase 3");
			Pila pila = new Pila();
			llenar(pila, 3);
			informar(pila,3);
			*/
			
			Profesor profe = (Profesor)FabricaDeComparables.crearAleatorio(3);

            List<Alumno> alumnos = new List<Alumno>();
            for (int i = 0; i < 20; i++)
            {
            	Alumno a = (Alumno)FabricaDeComparables.crearAleatorio(2);
                profe.agregarObservador(a);
                alumnos.Add(a);
            }
            
            dictadoDeClases(profe);
            
            
			
			Console.ReadKey(true);
		}
		
		static void informar(Coleccionable coleccion, int opcion)
		{
			Console.WriteLine("Cantidad de elementos: {0}", coleccion.cuantos());
			Console.WriteLine("Elemento mínimo: {0}", coleccion.minimo());
			Console.WriteLine("Elemento máximo: {0}", coleccion.maximo());
		
			Comparable comparable = FabricaDeComparables.crearPorTeclado(opcion) ;
    		if (coleccion.contiene(comparable))
    		{
    			Console.WriteLine("El elemento está en la colección.");
    		}
    		else 
    			Console.WriteLine("El elemento no se encuentra en la colección.");
		}
		
		static void llenar(Coleccionable c, int opcion)
		{
			for (int i = 0; i < 20; i++)
			{
				c.agregar(FabricaDeComparables.crearAleatorio(opcion));
			}
		}
		
		public static void dictadoDeClases(Profesor profesor)
        {
            for (int i = 0; i < 5; i++)
            {
                profesor.hablarALaClase();
                profesor.escribirEnElPizarron();
            }
        }
	}
}