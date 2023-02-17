using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 12: calcula poupança 2");

        /*
        int mes = 1;

        while (mes <= 12)
        {
            investimento += investimento * 0.005;

            Console.WriteLine($"No mês {mes} você terá {investimento.ToString("c")}");

            mes++;
        }
        */

        double investimento = 1000.0;

        for (int mes = 1; mes <= 12; mes++)
        {
            investimento *= 1.005;

            Console.WriteLine($"No mês {mes} você terá {investimento.ToString("c")}");
        }

        Console.WriteLine("Pressione ENTER para finalizar!");
        Console.ReadLine();
    }
}