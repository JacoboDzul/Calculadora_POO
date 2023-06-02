using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_POO.Clases
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Carrera { get; set; }
        public int Edad { get; set; }


        public void PedirDatos()
        {
            Console.WriteLine("ingresa tu nombre");
            this.Nombre = Console.ReadLine();
            Console.WriteLine("ingresa tu apellido");
            this.Apellido = Console.ReadLine();
            Console.WriteLine("ingresa tu carrera");
            this.Carrera = Console.ReadLine();
            Console.WriteLine("ingresa tu edad");
            Edad = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine(" tu nombre es:" + Nombre);
            Console.WriteLine(" tu apellido es:" + Apellido);
            Console.WriteLine(" tu Carrera es:" + Carrera);
            Console.WriteLine(" tu Edad es:" + Edad);
            if (Edad >= 18)
            {
                Menu menu = new Menu();
                menu.Opciones();
            }
            else
            {
                Console.WriteLine("Disculpe no es posible, por que usted es menor de edad");
                Console.WriteLine("Hola");
                Console.WriteLine("");
            }
        }
v

    }
}

