using System;
class Program
{
    static void Main()
    {
        Random random = new Random();
        int numeroSecreto = random.Next(1, 11);
        int intento;
        do
        {
            Console.Write("Adivina el número (entre 1 y 10): ");
            intento = int.Parse(Console.ReadLine());
        }while (intento != numeroSecreto);
        Console.WriteLine("¡Acertaste!");
    }
}
