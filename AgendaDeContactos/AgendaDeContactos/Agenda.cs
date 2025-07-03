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
                        AgregarContacto();
                        break;
                    case 3:
                        EliminarContactoDesdeMenu();
                        break;
                    case 4:
                        EditarContactoDesdeMenu();
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
                
                foreach (var c in _contactos)
                {
                    Console.WriteLine($"Clave: {c.Key} - {c.Value}");
                }
            }
            else
            {
                
                Console.WriteLine("No hay contactos en la agenda.");
            }
            
        }

        private void AgregarContacto()
        {
            Console.Clear();
            Console.WriteLine("Ingrese Los datos del nuevo contacto");

            try 
            {
                int numeroContactos = _contactos.Count + 1;

                Console.Write("Nombre: ");
                string nombre = Console.ReadLine();

                Console.Write("Ingrese el celular: ");
                string celular = Console.ReadLine();

                Console.Write("Ingrese el email: ");
                string email = Console.ReadLine();

                Contacto contacto = new Contacto(nombre,celular,email,DateTime.Now);
                _contactos.Add(numeroContactos++,contacto);


            }
            catch(Exception ex)  
            {

                Console.WriteLine($"Error al agregar conatcto: {ex.Message}");
            
            }
            Console.WriteLine("Contacto creado correctamente");

        }

        private void EliminarContactoDesdeMenu()
        {
            Console.Clear();
            try
            {
                Console.Write("\nIngrese el número de índice del contacto a eliminar: ");
                if (int.TryParse(Console.ReadLine(), out int indice) && _contactos.ContainsKey(indice))
                {
                    _contactos.Remove(indice);
                    Console.WriteLine("Contacto eliminado correctamente.");
                }
                else
                {
                    Console.WriteLine("Índice inválido.");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error al eliminar contacto");

            }
            
        }

        private void EditarContactoDesdeMenu()
        {
            Console.Clear();
            int contactoIndice = 0;
            try
            {

                Console.Write("\nIngrese el número de índice del contacto que desea editar: ");
                if (int.TryParse(Console.ReadLine(), out int indice) && _contactos.ContainsKey(indice))
                {
                    Contacto contacto = _contactos[indice];

                    Console.WriteLine("\nContacto actual:");
                    Console.WriteLine(contacto);

                    Console.Write("\nNuevo nombre (dejar vacío para no cambiar): ");
                    string nombre = Console.ReadLine();

                    Console.Write("Nuevo celular (dejar vacío para no cambiar): ");
                    string celular = Console.ReadLine();

                    Console.Write("Nuevo email (dejar vacío para no cambiar): ");
                    string email = Console.ReadLine();

                    contacto.Actualizar(nombre, celular, email);

                    Console.WriteLine("\nContacto actualizado correctamente.");

                }
                else
                {
                    Console.WriteLine("Contacto no existe");
                }

            }
            catch
            {
                Console.WriteLine("");

            }

            








        }


    }




}
