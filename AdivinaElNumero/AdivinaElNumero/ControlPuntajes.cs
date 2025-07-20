using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdivinaElNumero
{
    internal class ControlPuntajes
    {
        private int _puntos {  get; set; }
        private int _intentos { get; set; }
        private List<ControlPuntajes> _puntosList { get; set; }

        public ControlPuntajes(int puntos, int intentos, List<ControlPuntajes> listaPuntos)
        {
            _puntos = puntos = 0;
            _intentos = intentos = 0;
            _puntosList = listaPuntos;
            
        }

        public ControlPuntajes()
        {
            
        }

        public void sumarIntento()
        {

            _intentos += 1;

        }




    }
}
