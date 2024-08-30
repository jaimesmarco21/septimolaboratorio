using System;
class Program
{
    static void Main()
    {
        int numero = 123456;
        int contador = 0;
        do
        {
            numero /= 10;
            contador++;
        }while (numero != 0);
        Console.WriteLine(contador);
    }
}