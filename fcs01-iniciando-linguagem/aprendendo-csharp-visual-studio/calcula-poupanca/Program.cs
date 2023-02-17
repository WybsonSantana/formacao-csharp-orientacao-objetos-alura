using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 11: calcula poupança");

        double investimento = 1000.0;

        // Rendimento de 0,5% ao mês

        // Mês 1
        //investimento = investimento + investimento * 0.005;

        // Mês 2
        //investimento = investimento + investimento * 0.005;

        // Mês 3
        //investimento = investimento + investimento * 0.005;

        //Console.WriteLine(investimento);

        int mes = 1;

        while (mes <= 12)
        {
            investimento += investimento * 0.005;

            Console.WriteLine($"No mês {mes} você terá {investimento.ToString("c")}");

            mes++;
        }

        Console.WriteLine("Pressione ENTER para finalizar!");
        Console.ReadLine();
    }
}