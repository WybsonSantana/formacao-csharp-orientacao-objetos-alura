using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 10: desafio IR");

        double salario = 3300.0;

        if (salario < 1903.99)
        {
            Console.WriteLine("Isento de IR");
        }
        else if (salario >= 1903.99 && salario <= 2826.65)
        {
            Console.WriteLine("Alícota de 7,5%");
            Console.WriteLine("Dedução de até R$ 142,80");
        }
        else if (salario >= 2826.66 && salario <= 3751.05)
        {
            Console.WriteLine("Alícota de 15%");
            Console.WriteLine("Dedução de até R$ 354,80");
        }
        else if (salario >= 3751.06 && salario <= 4664.08)
        {
            Console.WriteLine("Alícota de 22,5%");
            Console.WriteLine("Dedução de até R$ 636,13");
        }
        else
        {
            Console.WriteLine("Alícota de 27,5%");
            Console.WriteLine("Dedução de até R$ 869,36");
        }

        Console.WriteLine("Pressione ENTER para finalizar");
        Console.ReadLine();
    }
}