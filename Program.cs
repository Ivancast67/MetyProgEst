using System;

namespace Saludo
{
    class Program
    {
        static void Main(string[] arg )
        {
            // ingrese nombre //
            Console.Write(" ingrese  nombre: ");
            string nombre = Console.ReadLine();

            // Saludo al usuario
            Console.WriteLine("¡Hola, " + nombre + "! Bienvenido/a.");
        }
    }
}
