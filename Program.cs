using System;

class Program
{
    static int a, b;

    static void Main()
    {
        Console.Write("Ingrese el primer entero: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el segundo entero: ");
        b = int.Parse(Console.ReadLine());
        fsuma();
    }

    static void fsuma()
    {
        Console.WriteLine("La suma es igual = " + (a + b));
    }
}
