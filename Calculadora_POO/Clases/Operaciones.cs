using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_POO.Clases
{
    public class Operaciones
    {

         
        public int Suma(int num1, int num2, int num3, int num4, int num5)
        {
           return (num1 + num2 + num3 + num4 + num5);

        }
        public int Resta(int num1, int num2)
        {
           return (num1 - num2);
        }

        public int Multiplicacion(int num1, int num2)
        {
            return (num1 * num2);
        }

        public double Cambiopeso(double num1)
        {
            return (num1 * 17.68);
        }
    
    }
}
