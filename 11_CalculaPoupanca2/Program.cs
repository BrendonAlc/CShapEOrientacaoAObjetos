using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 10 - Calcula Poupança");

        double investimento = 1000;

                int mes = 1;

        //rendimento de 0.5% (0.005) ao mês

        //While para verificação da quantidade de mês da condição
        /*while (mes <= 12)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine("No mês " + mes + " você tem R$ " + investimento);

            //Mes = mes + 1
            mes = mes++;
        }*/

        for(int mes = 1; mes <= 12; mes++);
        {
            investimento = investimento * 0.005;
            Console.WriteLine("No mês " + mes + " você tem R$ " + investimento);
        }


        Console.WriteLine("Tecle enter para fechar!");
        Console.ReadLine();
    }
}