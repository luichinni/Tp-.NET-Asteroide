using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1._1B
{
    class Sistema
    {
        Asteroide[] asteroides;
        int maxAsteroides = 10;
        public int[] MetalesTotales { get; private set; } = new int[Enum.GetValues(typeof(Metales)).Length];
        public int AsteroidesMinados { get; private set; }
        public string Nombre {  get; private set; }

        public Sistema()
        {
            Nombre = GenerarNombre(7);
            asteroides = GenerarAsteroides(maxAsteroides);
        }
        public void InformarSistema()
        {
            int kgMetalesSistema = 0;
            Console.WriteLine("======= ### =======");
            Console.WriteLine($"EN EL SISTEMA [{Nombre}] SE MINARON [{AsteroidesMinados}] ASTEROIDES\n");
            for (int i = 0; i < MetalesTotales.Length; i++)
            {
                Console.WriteLine($"{MetalesTotales[i]} KG de {(Metales)Enum.GetValues(typeof(Metales)).GetValue(i)}");
                kgMetalesSistema += MetalesTotales[i];
            }
            Console.WriteLine($"\nPor un total de {kgMetalesSistema} KG de carga");
            Console.WriteLine("======= ### =======");
        }
        public void ProcesarAsteroides()
        {
            foreach (Asteroide asteroid in asteroides)
            {
                for (int i=0; i < MetalesTotales.Length; i++)
                {
                    MetalesTotales[i] += asteroid.ComposicionMetalica[i];
                }
                AsteroidesMinados++;
            }
        }

        private Asteroide[] GenerarAsteroides(int maxAsteroides)
        {
            Random rand = new Random();
            Asteroide[] asteroidesRet = new Asteroide[rand.Next(maxAsteroides)];
            for (int i = 0; i < asteroidesRet.Length;i++) 
            {
                asteroidesRet[i] = new Asteroide();
            }
            return asteroidesRet;
        }

        private string GenerarNombre(int cantidadLetras)
        {
            /*
             * Genera un nombre aleatorio con los ascii del 65 al 90 (letras mayusculas)
             */
            Random rand = new Random();
            string nombreRetorno = "";
            for (int i = 0; i < cantidadLetras; i++)
            {
                nombreRetorno += Convert.ToChar(rand.Next(65, 91));
            }
            return nombreRetorno;

        }
    }
}
