using Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class Elisttasks
    {
        
        public void CrearListaTareas(string NombreLista)
        {
            var listatareas = new ListTaskRepositorio();
            listatareas.CrearLista(NombreLista);



        }

    }
}
