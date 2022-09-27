using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 8 - Condicionais");

        int idadeJoao = 16;
        int quantidadePessoas = 2;

        bool acompanhado = quantidadePessoas > 1; //Utilizando booleano para validar quantidade de pessoas com joao
        bool grupo = false;

        //Condicional para verificar se Joao tem mais de 18 anos e se está acompanhado.
        if (idadeJoao >= 18 || acompanhado)
        {
            Console.WriteLine("Pode entrar!");
        }
        else
        {
            Console.WriteLine("Não pode entrar!");
        }
        

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}