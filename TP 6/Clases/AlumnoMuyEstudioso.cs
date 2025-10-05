using System;

namespace TP_6
{
	public class AlumnoMuyEstudioso : Alumno
	{
		public AlumnoMuyEstudioso(string nom, int dni, int leg, double prom): base(nom, dni, leg, prom)
		{
		}
		
		public override int responderPregunta(int pregunta)
        {
            return pregunta % 3;
        }
	}
	
}
