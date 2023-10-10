using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1._1B
{
    class Asteroide
    {
        public TipoAsteroide TipoAsteroide { get; private set; }
        public int[] ComposicionMetalica { get; private set; }

        public Asteroide()
        {
            TipoAsteroide = GenerarTipo();
            ComposicionMetalica = GenerarComposicion();
        }

        private int[] GenerarComposicion()
        {
            int[] metalesRetorno = new int[Enum.GetValues(typeof(Metales)).Length];
            int kilosMaximo = (int) TipoAsteroide;
            int kilosActual = 0;
            for (int metal = 0; metal < metalesRetorno.Length; metal++)
            {
                metalesRetorno[metal] = GenerarMetal(kilosMaximo,kilosActual,metalesRetorno.Length-1,metal);
                kilosActual += metalesRetorno[metal];
            }
            return metalesRetorno;
        }

        private int GenerarMetal(int kgMax, int kgAct, int maxMetales, int metalAct)
            => (metalAct != maxMetales) ? (int)new Random().Next(kgMax - kgAct - 1) : kgMax - kgAct;

        private TipoAsteroide GenerarTipo()
        {
            Random rand = new Random();
            Array tipos = Enum.GetValues(typeof(TipoAsteroide));
            return (TipoAsteroide) tipos.GetValue(rand.Next(tipos.Length));
        }
    }
}
