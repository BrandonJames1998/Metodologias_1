using System;

namespace TP_2
{
	class Program
	{
		public static void Main(string[] args)
		{
			// EJERCICIOS 1-8
			/*
			Coleccionable pila = new Pila();
    		Coleccionable cola = new Cola();
    		Coleccionable conjunto = new Conjunto();
    		ColeccionMultiple multiple = new ColeccionMultiple(pila, cola);

    		LlenarAlumnos(pila);
    		LlenarAlumnos(cola);
    		LlenarAlumnos(conjunto);

    		
    		Console.WriteLine("=== Pila ===");
        	imprimirElementos(pila);

        	Console.WriteLine("=== Cola ===");
        	imprimirElementos(cola);

        	Console.WriteLine("=== Conjunto ===");
        	imprimirElementos(conjunto);
    		
    		
    		// Informar(multiple);
			*/
			
			// EJERCICIO 9
			Pila pila = new Pila();

	        // Llenarla con alumnos
	        LlenarAlumnos(pila);
	
	        // Comparación por nombre
	        cambiarEstrategia(pila, new CompararPorNombre());
	        Console.WriteLine("=== Estrategia: Nombre ===");
	        informar(pila);
	
	        // Comparación por legajo
	        cambiarEstrategia(pila, new CompararPorLegajo());
	        Console.WriteLine("=== Estrategia: Legajo ===");
	        informar(pila);
	
	        // Comparación por promedio
	        cambiarEstrategia(pila, new CompararPorPromedio());
	        Console.WriteLine("=== Estrategia: Promedio ===");
	        informar(pila);
	
	        // Comparación por DNI
	        cambiarEstrategia(pila, new CompararPorDni());
	        Console.WriteLine("=== Estrategia: DNI ===");
	        informar(pila);
			
			
			Console.Write("Press any key to continue . . . ");
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
		
		static void informar(Coleccionable coleccion)
	    {
	        Comparable minimo = coleccion.minimo();
	        Comparable maximo = coleccion.maximo();
	
	        Console.WriteLine("Mínimo: " + minimo);
	        Console.WriteLine("Máximo: " + maximo);
	        Console.WriteLine();
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
		
		public static void imprimirElementos(Coleccionable coleccion)
		{
    		Iterador iterador = ((Iterable)coleccion).crearIterador();
    		while (!iterador.fin())
    		{
        		Console.WriteLine(iterador.actual());
        		iterador.siguiente();
    		}
		}
		
		public static void cambiarEstrategia(Coleccionable coleccion, IEstrategiaAlumno estrategia)
		{
    		Iterador iterador = ((Iterable)coleccion).crearIterador();
    
    		while (!iterador.fin())
    		{	
        		Comparable c = iterador.actual();
        
        		// Casting seguro a Alumno
        		Alumno alumno = c as Alumno;
		        if (alumno != null)
		        {
		            alumno.setEstrategia(estrategia);
		        }
        
        		iterador.siguiente();
    		}
		}

	}
}