using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1._1B
{
    class Galaxia
    {
        Sistema sistemaActual;
        public int[] KgMetalesMinados { get; private set; } = new int[Enum.GetValues(typeof(Metales)).Length];

        public Galaxia() 
        {
            sistemaActual = new Sistema();
        }
        public void InformarGalaxia()
        {
            int kgMetalesTotal = 0;
            ActualizarMetales(sistemaActual.MetalesTotales);
            Console.WriteLine("======= ### =======");
            Console.WriteLine("Entre todos los sistemas se recolecto:\n");
            for (int i = 0; i < KgMetalesMinados.Length; i++)
            {
                Console.WriteLine($"{KgMetalesMinados[i]} KG de {(Metales)Enum.GetValues(typeof(Metales)).GetValue(i)}");
                kgMetalesTotal += KgMetalesMinados[i];
            }
            Console.WriteLine($"\nPor un total de {kgMetalesTotal} KG de carga");
            Console.WriteLine("======= ### =======");
        }
        public void ProximoSistema()
        {
            ActualizarMetales(sistemaActual.MetalesTotales);
            sistemaActual = new Sistema();
        }
        public void InformarSistema() => sistemaActual.InformarSistema();
        public void ProcesarSistema() => sistemaActual.ProcesarAsteroides();
        private void ActualizarMetales(int[] metalesMinados)
        {
            for (int i = 0; i < metalesMinados.Length; i++)
            {
                KgMetalesMinados[i] += metalesMinados[i];
            }
        }
    }
}
