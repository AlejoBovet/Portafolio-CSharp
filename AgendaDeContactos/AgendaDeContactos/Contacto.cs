using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaDeContactos
{
    internal class Contacto
    {
        private string _nombre;
        private int _celular;
        private string _email;
        private DateTime _fechaCreacion;

        public Contacto(string nombre, int celular, string email, DateTime fechaCreacion)
        {
            _nombre = nombre;
            _celular = celular;
            _email = email;
            _fechaCreacion = fechaCreacion;   
        }

        public override string ToString()
        {
            return $"Nombre: {_nombre}, Celular: {_celular}, Email: {_email}, Fecha: {_fechaCreacion:dd/MM/yyyy}";
        }

        public void SetContacto()
        {

        }

        public void DeleteConatcto() 
        {
        
        }

        public void UpdateContacto()
        {

        }


    }
}
