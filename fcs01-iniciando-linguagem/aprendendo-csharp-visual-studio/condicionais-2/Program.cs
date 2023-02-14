using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 8: condicionais 2");

        int idadeJoao = 16;
        int quantidadeDePessoas = 2;

        bool acompanhado = quantidadeDePessoas > 1;
        bool grupo = false;

        if (idadeJoao >= 18 || acompanhado)
        {
            Console.WriteLine("Entrada permitida!");
        }
        else
        {
            Console.WriteLine("Entrada não permitida!");
        }

        Console.WriteLine("Pressione ENTER para finalizar");
        Console.ReadLine();
    }
}