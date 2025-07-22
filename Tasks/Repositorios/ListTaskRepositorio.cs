using AccesosDatos.DataBase;
using Interfases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Repositorios
{
    public class ListTaskRepositorio:IListaTasks
    {
        public string NameList { get; }
        public int IdList { get; }

        public ListTaskRepositorio()
        {
            
        }

        public ListTaskRepositorio(string namelist)
        {
            NameList = namelist;
            
        }

        public void CrearLista(string NameList)
        {
            var db = new ClasDataBase(Config.ConnectionString);
            db.Open();
            db.ExecuteSelect($"Insert into ListaDeTareas nombre_lista VALUES {NameList}");
            db.Close();


        }
        public void EliminarLista(int idlist)
        {

        }

    }
}
