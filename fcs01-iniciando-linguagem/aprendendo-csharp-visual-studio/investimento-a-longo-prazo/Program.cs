using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 13: investimento a longo prazo");

        double investimento = 1000.0;
        double fatorRendimento = 1.005;

        for (int ano = 1; ano <= 5; ano++)
        {
            for (int mes = 1; mes <= 12; mes++)
            {
                investimento *= fatorRendimento;
            }
            fatorRendimento += 0.001;
        }

        Console.WriteLine($"Após 5 anos de investimento você terá {investimento.ToString("c")}");

        Console.WriteLine("Pressione ENTER para finalizar!");
        Console.ReadLine();
    }
}