using System;
using System.Collections.Generic;
namespace TP_1
{
	class Program
	{
		public static void Main(string[] args)
		{
			//  EJERCICIOS 1-8
			
			/*
			Coleccionable pila = new Pila();
			Coleccionable cola = new Cola();
			
			llenar(pila);
        	llenar(cola);
        	
        	Console.WriteLine("----- PILA -----");
        	informar(pila);

        	Console.WriteLine("\n----- COLA -----");
        	informar(cola);
        	
        	*/
        	// EJERCICIO 9
        	
        	/*
        	Pila pila = new Pila();
        	Cola cola = new Cola();
        	
        	ColeccionMultiple multiple = new ColeccionMultiple(pila, cola);
        	llenar(pila);
            llenar(cola);
            
            Console.WriteLine("=== Informar Pila ===");
            informar(pila);

            Console.WriteLine("\n=== Informar Cola ===");
            informar(cola);
            
            Console.WriteLine("\n=== Informar ColeccionMultiple ===");
            informar(multiple);
            */
        	
           //  EJERCICIO 14
           
           	Pila pila = new Pila();
			Cola cola = new Cola();
			Coleccionable multiple = new ColeccionMultiple(pila, cola);
			LlenarAlumnos(pila);
			LlenarAlumnos(cola);
			Informar(multiple);

			Console.ReadKey(true);
		}
		
		static void Llenar(Coleccionable coleccion) 
		{
        	Random rnd = new Random();
        	for (int i = 0; i < 20; i++) 
        	{
            	int valor = rnd.Next(1, 101); // número aleatorio entre 1 y 100
            	Comparable c = new Numero(valor);
            	coleccion.agregar(c);
        	}
		}
		
		static void Informar(Coleccionable coleccion)
		{
			Console.WriteLine("Cantidad de elementos: {0}", coleccion.cuantos());
			Console.WriteLine("Elemento mínimo: {0}", coleccion.minimo());
			Console.WriteLine("Elemento máximo: {0}", coleccion.maximo());
			Console.Write("Ingrese un número a buscar: ");
    		int valor = int.Parse(Console.ReadLine());
    		Comparable buscado = new Numero(valor);
    		if (coleccion.contiene(buscado))
    		{
    			Console.WriteLine("El elemento está en la colección.");
    		}
    		else 
    			Console.WriteLine("El elemento no se encuentra en la colección.");
		}
		
		static void LlenarAlumnos(Coleccionable coleccion)
		{
    		Random rnd = new Random();
    		string[] nombres = { "Ana", "Luis", "Pedro", "Maria", "Juan", "Laura" };

    		for (int i = 0; i < 20; i++)
    		{
        		string nombre = nombres[rnd.Next(nombres.Length)];
        		int dni = rnd.Next(10000000, 50000000);
        		int legajo = rnd.Next(1000, 9999);
        		double promedio = Math.Round(rnd.NextDouble() * 10, 2);
    		
        		Alumno nuevo = new Alumno(nombre, dni, legajo, promedio);
        		coleccion.agregar(nuevo);
    		}
		}
	}
}