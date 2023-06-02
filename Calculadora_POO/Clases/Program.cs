
using Calculadora_POO.Clases;
namespace Tarea
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.PedirDatos();
            Operaciones operaciones = new Operaciones();
            operaciones.ToString();
            Menu menu = new Menu();
            menu.Opciones();

            Console.WriteLine("Presione cualquier tecla para salir");
            Console.ReadKey();
        }
}

}