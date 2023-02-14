using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 6: atribuições e variáveis");

        int idade = 30;
        int idadeAna = idade;
        Console.WriteLine(idadeAna);

        idade = 25;
        Console.WriteLine(idade);

        Console.WriteLine("Pressione ENTER para finalizar!");
        Console.ReadLine();
    }
}