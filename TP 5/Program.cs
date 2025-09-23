using System;
using System.Collections.Generic;
using MetodologíasDeProgramaciónI;

namespace TP_5
{
	class Program
	{
		public static void Main(string[] args)
		{
			Teacher teacher = new Teacher();
			List<Student> students = new List<Student>();
			GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();
			
			for (int i = 0; i < 10; i++)
			{
				string nombre = "Alumno" + i;
				IAlumno proxy = new AlumnoProxy(nombre, 4);
			    AlumnoAdapter adapter = new AlumnoAdapter(proxy);
			    students.Add(adapter);
			}
			
			for (int i = 0; i < 10; i++)
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
	}
}