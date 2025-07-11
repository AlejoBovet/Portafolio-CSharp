namespace AdivinaElNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("¡Bienvenido al juego Adivina el Número!");
            Console.WriteLine("Estoy pensando en un número entre 1 y 100.");

            GeneradorNumero numeroSecreto = new GeneradorNumero();
            ControlPuntajes puntosPatida = new ControlPuntajes();
            int numeroPensado = numeroSecreto.getNumeroRandom();

            while (true)
            {
                Console.Write("Introduce tu suposición: ");
                string entrada = Console.ReadLine();

                int numero;
                if (int.TryParse(entrada, out numero))
                {
                    puntosPatida.sumarIntento();

                    if (numero < numeroPensado)
                    {
                        Console.WriteLine("Demasiado bajo. Intenta de nuevo.");
                    }
                    else if (numero > numeroPensado)
                    {
                        Console.WriteLine("Demasiado alto. Intenta de nuevo.");
                    }
                    else
                    {
                        Console.WriteLine($"¡Felicidades! Adivinaste el número en  intentos.");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, introduce un número entero.");
                }
            }

            Console.WriteLine("Presiona cualquier tecla para salir.");
            Console.ReadKey();



        }
    }
}
