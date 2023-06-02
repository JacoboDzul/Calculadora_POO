using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_POO.Clases
{
    public class Menu
    {
        public void Opciones()
        {
            Console.WriteLine("Ingresa una de las operaciones");
            Console.WriteLine("1: Suma");
            Console.WriteLine("2: Resta");
            Console.WriteLine("3: Multiplicacion");
            Console.WriteLine("4: Cambio de divisas");
            int opcion = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Ingresa el primer valor");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el segundo valor");
            int num2 = int.Parse(Console.ReadLine());

            int num3 = 0;
            int num4 = 0;
            int num5 = 0;

            if (opcion == 1)
            {
                Console.WriteLine("Ingresa el tercer valor");
                num3 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa el cuarto valor");
                num4 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa el Quinto valor");
                num5 = int.Parse(Console.ReadLine());
            }
            else if (opcion == 2 || opcion == 3)
            {
                Console.WriteLine("Ingresa el tercer valor");
                num3 = int.Parse(Console.ReadLine());
            }
            else if (opcion == 4)
            {
                Console.WriteLine("Ingresa el tercer valor");
                num3 = int.Parse(Console.ReadLine());
            }

            Operaciones operacion = new Operaciones();

            switch (opcion)
            {
                case 1:
                    int result = operacion.Suma(num1, num2, num3, num4, num5);
                    Console.WriteLine("El resultado es " + result);
                    break;
                case 2:
                    int result2 = operacion.Resta(num1, num2);
                    Console.WriteLine("El resultado es " + result2);
                    break;
                case 3:
                    int result3 = operacion.Multiplicacion(num1, num2);
                    Console.WriteLine("El resultado es " + result3);
                    break;
                case 4:
                    double result4 = operacion.Cambiopeso(num1);
                    Console.WriteLine("El resultado es " + result4);
                    break;
                default:
                    Console.WriteLine("No disponible");
                    break;
            }
        }

    }

}

