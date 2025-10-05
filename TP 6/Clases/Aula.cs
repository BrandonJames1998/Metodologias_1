using System;
using MetodologíasDeProgramaciónI;

namespace TP_6
{
	public class Aula
	{
		private Teacher teacher;
		
		public void comenzar()
		{
			Console.WriteLine("Comienza la clase...");
			teacher = new Teacher();
		}
		
		public void nuevoAlumno(IAlumno a)
		{
			teacher.goToClass(new AlumnoAdapter(a));
		}
		
		public void claseLista()
		{
			teacher.teachingAClass();
		}
	}
}
