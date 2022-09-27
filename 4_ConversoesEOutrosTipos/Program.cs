using System;

class Programa
{
    static void Main(string[] args)
    {
        double salario = 3000.15;
        Console.WriteLine(salario);

        int salarioInteiro = (int)salario; //Utilizando cast para converter o tipo da variavel
        Console.WriteLine(salarioInteiro);  

        long x = 200000000000000000; //long armazenamento de variaveis até 64 bits
        Console.WriteLine(x);

        short y = 15000; //short armazenamento de variaveis até 16 bites, valores que não seram grandes
        Console.WriteLine(y);

        float altura = 1.62f; //float utilizando o f para poder utilizar a variavel na tipagem utilizada, utilizar quando tiver certeza do modo de tipagem
        Console.WriteLine(altura);



        Console.WriteLine("Aperte enter para fechar.");
        Console.ReadLine();
    }
}