using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 12 - Investimento a longo prazo");

        double fatorRendimento = 1.005;
        double invetimento = 1000;

        //Laço dentro para verificar investimento dentro de 5 anos

        for(int anos = 1; anos <= 5; anos++)
        {
            for(int mes = 1; mes <= 12; mes++)
            {
                investimento *= fatorRendimento;
            }
            fatorRendimento = fatorRendimento + 0.001;
        }

        Console.WriteLine("Em 5 anos de investimento você terá R$: " + investimento);

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}

