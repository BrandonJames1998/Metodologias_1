using System;

namespace TP_6
{
    public class DecoradorRecuadroExtendido : DecoradorAlumno
    {
        private static int contador = 1;
        private int indice;

        public DecoradorRecuadroExtendido(IAlumno alumno) : base(alumno)
        {
            this.indice = contador++;
        }

        public override string mostrarCalificacion()
        {
            string textoInterno = alumno.getNombre() + " (" + alumno.getLegajo() + ") " +
                                  alumno.getCalificacion() + " (" + NumeroALetras(alumno.getCalificacion()) + ")";

            string textoConIndice = indice + ") " + textoInterno;

            string linea = new string('*', textoConIndice.Length + 4);
            return linea + "\n" +
                   "* " + textoConIndice + " *\n" +
                   linea;
        }

        private string NumeroALetras(int nota)
        {
            string[] letras = { "CERO","UNO","DOS","TRES","CUATRO","CINCO","SEIS","SIETE","OCHO","NUEVE","DIEZ" };
            return letras[nota];
        }
    }
}



