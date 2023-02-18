using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 15: múltiplos de 3");

        // Incrementando +3
        for (int i = 0; i <= 100; i += 3)
        {
            if (i > 0)
            {
                Console.WriteLine(i);
            }
        }

        Console.WriteLine();

        // Divisível por 3
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine(i);
            }
        }

        Console.WriteLine("Pressione ENTER para finalizar!");
        Console.ReadLine();
    }
}