using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 5: caracteres e textos");

        char letra = 'a';
        Console.WriteLine(letra);

        letra = (char)65;
        Console.WriteLine(letra);

        letra = (char)(65 + 1);
        Console.WriteLine(letra);

        letra = (char)(86 + 1);
        Console.WriteLine(letra);

        Console.WriteLine("Pressione EnTER para finalizar!");
        Console.ReadLine();
    }
}