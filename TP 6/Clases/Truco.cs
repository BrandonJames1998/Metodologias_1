using System;

namespace TP_6
{

	public class Truco : JuegoDeCartas
	{
		private Random rnd = new Random();
        private int puntosJugador1 = 0;
        private int puntosJugador2 = 0;
        private int ronda = 0;
        
		public Truco()
		{
		}
		protected override void mezclar()
		{
			Console.WriteLine("Mezclando el mazo de Truco...");
		}
		protected override void repartir()
		{
			Console.WriteLine("Repartiendo 3 cartas a cada jugador.");
		}
		protected override void tomarCartas()
		{
			ronda++;
            Console.WriteLine("");
            Console.WriteLine("--- Ronda " + ronda + " ---");

            int cartaJugador1 = rnd.Next(1, 13);
            int cartaJugador2 = rnd.Next(1, 13);

            Console.WriteLine("Jugador 1 juega " + cartaJugador1);
            Console.WriteLine("Jugador 2 juega " + cartaJugador2);

            if (cartaJugador1 > cartaJugador2)
            {
                puntosJugador1++;
                Console.WriteLine("Jugador 1 gana la mano!");
            }
            else if (cartaJugador2 > cartaJugador1)
            {
                puntosJugador2++;
                Console.WriteLine("Jugador 2 gana la mano!");
            }
            else
            {
                Console.WriteLine("Empate en la mano.");
            }
		}
		protected override void descartar()
		{
			Console.WriteLine("Ambos jugadores descartan una carta.");
		}
		protected override bool hayGanador()
		{
			if (puntosJugador1 == 2)
            {
                Console.WriteLine("");
                Console.WriteLine("¡Jugador 1 gana el truco!");
                return true;
            }
            if (puntosJugador2 == 2)
            {
                Console.WriteLine("");
                Console.WriteLine("¡Jugador 2 gana el truco!");
                return true;
            }
            return false;
		}
	}
}
