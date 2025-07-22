using LogicaNegocio;

namespace ConsoleApp1

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista de tareas");
            Console.WriteLine("crear lista de tareas");
            string nombreLista = Console.ReadLine() ?? "Lista Sin Nombre";

            var listaTareas = new Elisttasks();
            listaTareas.CrearListaTareas(nombreLista);
        }
    }
}
