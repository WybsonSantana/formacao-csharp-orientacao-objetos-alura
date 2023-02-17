using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 14: encadeando for");

        //*
        //**
        //***
        //****
        //*****

        // Com break
        for (int linha = 0; linha < 10; linha++)
        {
            for (int coluna = 0; coluna < 10; coluna++)
            {
                Console.Write("*");
                if (coluna >= linha)
                    break;
            }
            Console.WriteLine();
        }

        // Sem break
        for (int linha = 0; linha < 10; linha++)
        {
            for (int coluna = 0; coluna <= linha; coluna++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Pressione ENTER para finalizar");
        Console.ReadLine();
    }
}