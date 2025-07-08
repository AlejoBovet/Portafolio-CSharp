namespace AdivinaElNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("¡Bienvenido al juego Adivina el Número!");
            Console.WriteLine("Estoy pensando en un número entre 1 y 100.");



            // Bucle principal del juego
            do
            {
                GeneradorNumero numeroSecreto = new GeneradorNumero();
                ControlPuntajes puntosPatida = new ControlPuntajes();
                int numneroPensado = numeroSecreto.getNumeroRandom();
                Console.Write("Introduce tu suposición: ");
                string entrada = Console.ReadLine();

                if (int.TryParse(entrada, out numneroPensado))
                {
                    puntosPatida.sumarIntento();

                    // Comprueba si la suposición es correcta
                    if (entrada < numneroPensado)
                    {
                        Console.WriteLine("Demasiado bajo. Intenta de nuevo.");
                    }
                    else if (entrada > numeroSecreto)
                    {
                        Console.WriteLine("Demasiado alto. Intenta de nuevo.");
                    }
                    else
                    {
                        Console.WriteLine($"¡Felicidades! Adivinaste el número en {intentos} intentos.");
                        break; // Sale del bucle si adivinó
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, introduce un número entero.");
                }



                Console.WriteLine("Presiona cualquier tecla para salir.");
                Console.ReadKey();
            

            
        }
    }
}
