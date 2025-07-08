using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdivinaElNumero
{
    internal class GeneradorNumero
    {
        private int _numeroRandom;


        public GeneradorNumero()
        {
            
             
            _numeroRandom = GenerarNumeroRandom();

        }

        public int getNumeroRandom()
        {
            return _numeroRandom;
        }

        private int GenerarNumeroRandom()
        {
            Random random = new Random();
            int numeroSecreto = random.Next(1, 101);
            return numeroSecreto;
        }
    }
}
