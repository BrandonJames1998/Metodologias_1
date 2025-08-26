using System;
using System.Collections.Generic;
namespace TP_1
{
	class Program
	{
		public static void Main(string[] args)
		{
			Coleccionable pila = new Pila();
			Coleccionable cola = new cola();
			
			
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
    		if (coleccion.contiene(valor))
    		{
    			Console.WriteLine("El elemento está en la colección.");
    		}
    		else 
    			Console.WriteLine("El elemento no se encuentra en la colección.");
		}
	}
}