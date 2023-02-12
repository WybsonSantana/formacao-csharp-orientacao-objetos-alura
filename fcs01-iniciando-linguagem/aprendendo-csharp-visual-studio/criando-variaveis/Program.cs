using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 2: criando variáveis");

        int idade;

        idade = 27;
        Console.WriteLine("A idade de Fulano é " + idade);

        idade = 27 - 5;
        Console.WriteLine(idade);

        idade = 5 * 2 - 6;
        Console.WriteLine(idade);

        idade = (5 - 2) * 3;
        Console.WriteLine(idade);

        Console.WriteLine("Pressione ENTER para finalizar!");
        Console.ReadLine();
    }
}