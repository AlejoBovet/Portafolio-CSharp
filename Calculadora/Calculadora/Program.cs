namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a calculadora");

            Console.WriteLine("Ingrese una opcion por favor");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ha seleccionado Suma");

                    Console.WriteLine("Ingrese el primer numero");
                    double nums1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero");
                    double nums2 = double.Parse(Console.ReadLine());

                    Operations operationSum = new Operations();
                    double resultadoSum = operationSum.Sumar(nums1, nums2);  

                    Console.WriteLine($"Resultado: {resultadoSum}"); 
                    break;

                case 2:
                    Console.WriteLine("Ha seleccionado Resta");
               
                    Console.WriteLine("Ingrese el primer numero");
                    double numr1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero");
                    double numr2 = double.Parse(Console.ReadLine());

                    Operations operationRest = new Operations();
                    double resultadoRest = operationRest.Resta(numr1, numr2);

                    Console.WriteLine($"Resultado: {resultadoRest}");
                    break;

                case 3:
                    Console.WriteLine("Multiplicacion");
                    Console.WriteLine("Ha seleccionado Suma");

                    Console.WriteLine("Ingrese el primer numero");
                    double numm1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero");
                    double numm2 = double.Parse(Console.ReadLine());

                    Operations operationMult = new Operations();
                    double resultadoMult = operationMult.Multiplicacion(numm1, numm2);

                    Console.WriteLine($"Resultado: {resultadoMult}");
                    break;

                case 4:
                    Console.WriteLine("Divicion");
                    Console.WriteLine("Ha seleccionado Suma");

                    Console.WriteLine("Ingrese el primer numero");
                    double numd1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero");
                    double numd2 = double.Parse(Console.ReadLine());

                    Operations operationDiv = new Operations();
                    double resultadoDiv = operationDiv.Dividir(numd1, numd2);

                    Console.WriteLine($"Resultado: {resultadoDiv}");
                    break;

                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }

            Console.ReadKey();
        }

    }
}
