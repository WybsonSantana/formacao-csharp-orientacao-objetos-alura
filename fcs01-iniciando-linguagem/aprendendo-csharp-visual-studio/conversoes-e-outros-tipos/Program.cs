using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 4: criando variáveis de outros tipos");

        double salario = 3000.15;
        Console.WriteLine(salario);

        int salarioInteiro = (int)salario;
        Console.WriteLine(salarioInteiro);

        // O long é um tipo de variável de 64 bits
        long x = 2000000000000000000; ;
        Console.WriteLine(x);

        short y = 15000;
        Console.WriteLine(y);

        float altura = 1.62f;
        Console.WriteLine(altura);

        Console.WriteLine("Pressione ENTER para finalizar!");
        Console.ReadLine();
    }
}