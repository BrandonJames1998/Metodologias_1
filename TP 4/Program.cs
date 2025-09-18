using System;
using System.Collections.Generic;
using MetodologíasDeProgramaciónI;

namespace TP_4
{
	class Program
	{
		public static void Main(string[] args)
		{
			Teacher teacher = new Teacher();
			List<Student> students = new List<Student>();
			
			GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();
			
			/* 10 Alumnos normales
			for (int i = 0; i < 10; i++)
			{
			    Alumno a = (Alumno)FabricaDeComparables.crearAleatorio(2);
			    Student s = new AlumnoAdapter(a);
			    students.Add(s);
			}
			
			*/
			
			/* 10 Alumnos muy estudiosos
			for (int i = 0; i < 10; i++)
			{
			    AlumnoMuyEstudioso am = new AlumnoMuyEstudioso(
			        gen.stringAleatorio(),                
			        gen.numeroAleatorio(100000000),       
			        gen.numeroAleatorio(500000),          
			        gen.numeroAleatorio(10)               
			    );
			    Student s = new AlumnoAdapter(am);
			    students.Add(s);
			}
			
			foreach (Student s in students)
			{
			    teacher.goToClass(s);
			}
			
			teacher.teachingAClass();
			
			*/
			
			/*Ejercicio 7
			Comparable c = FabricaDeComparables.crearAleatorio(4);
			AlumnoAdapter adapter = c as AlumnoAdapter;
			
			Console.WriteLine(adapter.showResult());
			*/
			
			// Ejercicio 8
			
			for (int i = 0; i < 10; i++)
		    {
		        IAlumno c = (IAlumno)FabricaDeComparables.crearAleatorio(4);
			    AlumnoAdapter adapter = new AlumnoAdapter(c); 
			    students.Add(adapter);
		    }
			
			for (int i = 0; i < 10; i++)
		    {
				IAlumno am = (IAlumno)FabricaDeComparables.crearAleatorio(5);
			    
				IAlumno decorado = new DecoradorLegajo(am);
				decorado = new DecoradorNotaEnLetras(decorado);
			    decorado = new DecoradorCondicion(decorado);
			    decorado = new DecoradorRecuadro(decorado);
			    decorado = new DecoradorRecuadroExtendido(decorado);
			    
			    AlumnoAdapter adapter = new AlumnoAdapter(decorado);
			    students.Add(adapter);
		    }
			
			for (int i = 0; i < students.Count; i++)
		    {
		        Student s = students[i];
		        
		        AlumnoAdapter adapter = s as AlumnoAdapter;
		        if (adapter != null)
		            teacher.goToClass(adapter);
		    }
		    
		    teacher.teachingAClass();
		    
			Console.WriteLine("\n***** LISTADO DE CALIFICACIONES *****\n");
		    for (int i = 0; i < students.Count; i++)
		    {
		        Student s = students[i];
		        AlumnoAdapter adapter = s as AlumnoAdapter;
		        if (adapter != null)
		        {
		            Console.WriteLine(adapter.showResult());
		        }
		    }
							
			Console.Write("Press any key to continue . . . ");
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