using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AgendaDeContactos
{
    internal class Contacto
    {
        private string _nombre;
        private string _celular;
        private string _email;
        private DateTime _fechaCreacion;

        public Contacto(string nombre, string celular, string email, DateTime fechaCreacion)
        {

            if (string.IsNullOrEmpty(nombre))
                throw new ArgumentNullException("el nombre no puede estar vacio");

            if (!ValidarCelular(celular))
                throw new ArgumentException("el numero de celular no es valido");

            if (!ValidarCorreo(email))
                throw new ArgumentException("el correo no es valido");


            _nombre = nombre;
            _celular = celular;
            _email = email;
            _fechaCreacion = fechaCreacion;   
        }

        public void Actualizar(string nombre, string celular, string email)
        {
            if (!string.IsNullOrWhiteSpace(nombre))
                _nombre = nombre;

            if (!string.IsNullOrWhiteSpace(celular) && celular.All(char.IsDigit))
                _celular = celular;

            if (!string.IsNullOrWhiteSpace(email) && email.Contains("@"))
                _email = email;
        }

        public override string ToString()
        {
            return $"Nombre: {_nombre}, Celular: {_celular}, Email: {_email}, Fecha: {_fechaCreacion:dd/MM/yyyy}";
        }

        public static bool ValidarCelular(string celular)
        {
            return Regex.Match(celular, @"^([0-9]{9})$").Success;
        }

        public static bool ValidarCorreo(string correo) 
        {
            return Regex.Match(correo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$").Success;
        
        }
    }
}
