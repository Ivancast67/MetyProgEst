using System;

class Program
{
    static void Main()
    {
        int numEntero, Cociente, Residuo;
        Console.Write("\nDigite un número entero: ");
        numEntero = int.Parse(Console.ReadLine());
        Cociente = numEntero / 2;
        Residuo = numEntero - (Cociente * 2);

        if (Residuo == 0)
        {
            Console.WriteLine("El número es par");
        }

        Console.WriteLine("Presione cualquier tecla para continuar...");
        Console.ReadKey();
    }
}