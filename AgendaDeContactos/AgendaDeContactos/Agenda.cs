using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AgendaDeContactos
{
    internal class Agenda
    {

        private Dictionary<int, Contacto> _contactos;

        public Agenda(Dictionary<int,Contacto> contacto)    
        {
             _contactos = contacto;
       
        }

        public Agenda()
        {

            _contactos = new Dictionary<int, Contacto>();

        }

        public void MenuAgenda()
        {
            
            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("=== Agenda de Contactos ===");
                Console.WriteLine("1. Ver contactos");
                Console.WriteLine("2. Agregar contacto");
                Console.WriteLine("3. Eliminar contacto");
                Console.WriteLine("4. Editar contacto");
                Console.WriteLine("5. Cerrar Agenda");
                Console.Write("Seleccione una opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Opción inválida. Presione una tecla para continuar...");
                    Console.ReadKey();
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        VerContactos();
                        break;
                    case 2:
                        //AgregarContacto();
                        break;
                    case 3:
                        //EliminarContactoDesdeMenu();
                        break;
                    case 4:
                        //EditarContactoDesdeMenu();
                        break;
                    case 5:
                        Console.WriteLine("Agenda cerrada. ¡Hasta luego!");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }

                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();

            } while (opcion != 5);
        }

        private void VerContactos()
        {
            Console.Clear();

            if (_contactos.Count > 0)
            {
                // Hay contactos
                foreach (var c in _contactos)
                {
                    Console.WriteLine($"Clave: {c.Key} - {c.Value}");
                }
            }
            else
            {
                // No hay contactos
                Console.WriteLine("No hay contactos en la agenda.");
            }
            
        }

        private void AgregarContacto()
        {
            
            Console.WriteLine("Ingrese Los datos del nuevo contacto");

            Console.Write("Nombre");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese el celular: ");
            int celular = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el email: ");
            string email = Console.ReadLine();


            try 
            {



                Contacto contacto = new Contacto(nombre,celular,email,DateTime.Now);

            }
            catch 
            { 
            
            
            }



            


        }


    }




}
