using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Operations
    {
        public double Num1 { get; set; }
        public double Num2 { get; set; }

        public double Sumar(double num1, double num2)
        {
            Num1 = num1;
            Num2 = num2;
            return Num1 + Num2;
        }

        public double Resta(double num1, double num2)
        {
            Num1 = num1;
            Num2 = num2;
            return Num1 - Num2;
        }

        public double Multiplicacion(double num1, double num2)
        {
            Num1 = num1;
            Num2 = num2;
            return Num1 * Num2;
        }

        public double Dividir(double num1, double num2)
        {
            Num1 = num1;
            Num2 = num2;

            if (Num2 == 0)
            {
                throw new DivideByZeroException("No se puede dividir por cero.");
            }

            return Num1 / Num2;
        }


    }

}
