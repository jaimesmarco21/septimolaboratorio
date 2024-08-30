using System;
class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número: ");
        int n = int.Parse(Console.ReadLine());
        int i = 1;
        do
        {
            Console.WriteLine(i);
            i++;
        }while (i <= n);
    }
}
