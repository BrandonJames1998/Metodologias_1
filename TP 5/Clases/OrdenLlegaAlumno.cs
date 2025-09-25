using System;

namespace TP_5
{
	public class OrdenLlegaAlumno : IOrdenEnAula2
	{
		private Aula aula;
		
		public OrdenLlegaAlumno(Aula a)
		{
			this.aula = a;
		}
		
		public void ejecutar(Comparable a)
		{
			aula.nuevoAlumno((Alumno)a);
		}
	}
}
