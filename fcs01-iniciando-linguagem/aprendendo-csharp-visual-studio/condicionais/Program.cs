using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 7: condicionais");

        int idadeJoao = 16;
        int quantidadeDePessoas = 2;

        if (idadeJoao >= 18)
        {
            Console.WriteLine("Entrada permitida!");
        }
        else
        {
            if (quantidadeDePessoas > 1)
            {
                Console.WriteLine("Pessoa acompanhada. Pode entrar!");
            }
            else
            {
                Console.WriteLine("Entrada não permitida!");
            }
        }

        Console.WriteLine("Pressione ENTER para finalizar");
        Console.ReadLine();
    }
}