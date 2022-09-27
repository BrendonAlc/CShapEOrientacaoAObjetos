using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 5 - Caracteres e textos");

        char letra = 'a';
        Console.WriteLine(letra);

        letra = (char)65;
        Console.WriteLine(letra);

        letra = (char)(65 + 1);
        Console.WriteLine(letra);

        letra = (char)(87 + 2);
        Console.WriteLine(letra);

        string primeiraFrase = "Brendon - Aprendendo C#";
        Console.WriteLine(primeiraFrase + " em 2022");

        string vazia = "";
        Console.WriteLine(vazia);

        letra = ' ';

        //Utilizando @ para realizar listagem
        string cursos = @"Cursos: 
- Go 
- C# 
- Pyton 
- Java";

        Console.WriteLine(cursos);

        Console.WriteLine("Aperte enter para fechar.");
        Console.ReadLine();
    }
}