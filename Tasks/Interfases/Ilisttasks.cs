using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfases
{
    public interface IListaTasks
    {
        string NameList { get; }
        int IdList { get; }        

        void CrearLista(string NameList);
        void EliminarLista(int idlist);
    }

}
