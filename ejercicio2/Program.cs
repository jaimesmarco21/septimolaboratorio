﻿using System;
class Program
{
    static void Main()
    {
        int suma = 0;
        int numero;
        do
        {
            Console.Write("Ingrese un número (0 para terminar): ");
            numero = int.Parse(Console.ReadLine());
            suma += numero;
        }while (numero != 0);
        Console.WriteLine($"La suma total es: {suma}");
    }
}
