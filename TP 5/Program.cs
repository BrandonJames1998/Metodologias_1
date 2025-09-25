using System;
using System.Collections.Generic;
using MetodologíasDeProgramaciónI;

namespace TP_5
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Ejercicio 10
			
			Aula aula = new Aula();
			Pila pila = new Pila();
			
			pila.setOrdenInicio(new OrdenInicio(aula));
			pila.setOrdenLlegaAlumno(new OrdenLlegaAlumno(aula));
			pila.setOrdenAulaLlena(new OrdenAulaLlena(aula));
			
			llenar(pila, 2);
			llenar(pila, 5);
			
			
			
			
			
			/*
			Teacher teacher = new Teacher();
			List<Student> students = new List<Student>();
			GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();
			
			for (int i = 0; i < 2; i++)
			{
				string nombre = "Alumno" + i;
				IAlumno proxy = new AlumnoProxy(nombre, 7);
			    AlumnoAdapter adapter = new AlumnoAdapter(proxy);
			    students.Add(adapter);
			}
			
			for (int i = 0; i < 2; i++)
			{
				string nombre = "Alumno" + i;
				IAlumno proxy = new AlumnoProxy(nombre, 6);
			    AlumnoAdapter adapter = new AlumnoAdapter(proxy);
			    students.Add(adapter);
			}
			
			foreach (AlumnoAdapter s in students)
		    {
		    	teacher.goToClass(s);
		    }
		    
		    teacher.teachingAClass();
		    
			Console.WriteLine("\n***** LISTADO DE CALIFICACIONES *****\n");
		    foreach (AlumnoAdapter s in students)
		    {  
		 	   Console.WriteLine(s.showResult());  
		    }
			*/
			
			
			/*
			for (int i = 0; i < 10; i++)
		    {
		        IAlumno c = (IAlumno)FabricaDeComparables.crearAleatorio(4);
			    AlumnoAdapter adapter = new AlumnoAdapter(c); 
			    students.Add(adapter);
		    }
			
			for (int i = 0; i < 10; i++)
		    {
				IAlumno am = (IAlumno)FabricaDeComparables.crearAleatorio(6);    
			    AlumnoAdapter adapter = new AlumnoAdapter(am);
			    students.Add(adapter);
		    }
		    */
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		static void llenar(Coleccionable c, int opcion)
		{
			for (int i = 0; i < 20; i++)
			{
				c.agregar(FabricaDeComparables.crearAleatorio(opcion));
			}
		}
	}
}