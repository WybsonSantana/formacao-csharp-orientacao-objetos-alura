using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 16: fatorial");

        int fatorial = 1;

        for (int i = 1; i <= 10; i++)
        {
            fatorial *= i;
            Console.WriteLine($"O fatorial de {i} é {fatorial}");
        }

        Console.WriteLine("Pressione ENTER para finalizar!");
        Console.ReadLine();
    }
}