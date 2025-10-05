using System;
using System.Text;

namespace TP_6
{
	public class GeneradorDeDatosAleatorios
	{
		Random random = new Random();
		
		public int numeroAleatorio(int max)
		{
			return this.random.Next(0, max);
		}
		
		public string stringAleatorio(int cant = 5)
		{
			const string alfabeto = "abcdefghijklmnñopqrstuvwxyz";
			StringBuilder token = new StringBuilder();
			for (int i = 0; i < cant; i++)
			{
				int indice = random.Next(alfabeto.Length);
				token.Append(alfabeto[indice]);
			}
			return token.ToString();
		}
	}
}
