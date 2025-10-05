using System;

namespace TP_6
{

	public class FabricaDeAlumnosCompuestos : FabricaDeComparables
	{
		public override Comparable crearAleatorio()
        {
            AlumnoCompuesto compuesto = new AlumnoCompuesto();
          
            for (int i = 0; i < 5; i++)
            {
                string nombre = "Proxy_" + generador.stringAleatorio(5);
                AlumnoProxy proxy = new AlumnoProxy(nombre, 2);
                compuesto.agregarHijo(proxy);
            }

            return compuesto;
        }
		
		public override Comparable crearPorTeclado()
        {
            AlumnoCompuesto compuesto = new AlumnoCompuesto();

            for (int i = 0; i < 5; i++)
            {
                string nombre = lector.stringPorTeclado();
                AlumnoProxy proxy = new AlumnoProxy(nombre, 2);
                compuesto.agregarHijo(proxy);
            }

            return compuesto;
        }
	}
}
