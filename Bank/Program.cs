using System;

class Programa{
    static void Main(string[] args)
    {
        Console.WriteLine("Boas Vindas ao seu banco, Bank!");

        string titular = "Brendon Alcantara";
        string conta = "10123-x";
        int numero_agencia = 23;
        string nome_agencia = "Agencia Central";
        double saldo = 93.50;

        Console.WriteLine("Titular : " + titular);
        Console.WriteLine("Conta: " + conta);
        Console.WriteLine("Número da agência: " + numero_agencia);
        Console.WriteLine("Nome da Agencia: " + nome_agencia);
        Console.WriteLine("Saldo: " + saldo);
    }
}


