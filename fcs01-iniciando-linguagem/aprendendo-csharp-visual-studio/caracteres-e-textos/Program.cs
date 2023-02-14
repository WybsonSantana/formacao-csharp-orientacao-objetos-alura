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

        string primeiraFrase = "Alura cursos de tecnologia ";
        Console.WriteLine(primeiraFrase);
        Console.WriteLine(primeiraFrase + 2023);

        string vazia = "";
        Console.WriteLine(vazia);

        letra = ' ';
        Console.WriteLine(letra);

        string cursos = @"Cursos disponíveis:
- Java;
- Kotlin;
- C#;
- Python;
- GO;
- JavaScript.";
        Console.WriteLine(cursos);
        Console.WriteLine("Pressione EnTER para finalizar!");
        Console.ReadLine();
    }
}