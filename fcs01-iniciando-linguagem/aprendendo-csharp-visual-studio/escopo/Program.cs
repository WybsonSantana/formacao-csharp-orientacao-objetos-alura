using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 9: escopo");

        int idadeJoao = 16;
        int quantidadeDePessoas = 2;

        bool acompanhado = quantidadeDePessoas > 1;

        string textoAdicional;

        if (acompanhado == true)
        {
            textoAdicional = "João está acompanhado.";
        }
        else
        {
            textoAdicional = "João não está acompanhado.";
        }

        if (idadeJoao >= 18 || acompanhado)
        {
            Console.WriteLine(textoAdicional);
            Console.WriteLine("Entrada permitida!");
        }
        else
        {
            Console.WriteLine(textoAdicional);
            Console.WriteLine("Entrada não permitida!");
        }

        Console.WriteLine("Pressione ENTER para finalizar");
        Console.ReadLine();
    }
}