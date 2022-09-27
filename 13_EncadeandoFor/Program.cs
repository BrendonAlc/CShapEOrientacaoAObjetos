using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 13 - Encadeando For");

        //Criando for encadeado para ir acrescentendo a quantidade de asteriscos
        //*
        //**
        //***
        //****
        //*****


        //Com break
        for (int contadorLinhas = 0; contadorLinhas < 10; contadorLinhas++)
        {
            for (int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
            {
                Console.WriteLine("*");
                if (contadorCoulunas >= contadorLinhas)
                break;
            }
            Console.WriteLine();
        }

        //Segunda opção sem break

        for (int contadorLinhas = 0; contadorLinhas < 10; contadorLinhas++)
        {
            for (int contadorCoulna = 0; contadorColuna <= contadorLinhas; contadorColuna++)
            {
                Console.WriteLine("*");
            }
        }

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}

