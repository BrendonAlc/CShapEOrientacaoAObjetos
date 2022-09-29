using System;
using bytebank;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Boas Vindas ao seu banco, AlcBank!");

        
        ContaCorrente conta1 = new ContaCorrente();
        conta1.titular = "Brendon";
        conta1.conta = "123-x";
        conta1.numero_agencia = 23;
        conta1.nome_agencia = "Agencia Central";
        conta1.saldo = 100;

        ContaCorrente conta2 = new ContaCorrente();
        conta2.titular = "Luciana";
        conta2.conta = "145-x";
        conta2.numero_agencia = 15;
        conta2.nome_agencia = "Agencia Central";
        conta2.saldo = 100;

        Console.WriteLine("Saldo da Luciana pré-saque: " + conta2.saldo);

        bool saque = conta2.Sacar(30);
        Console.WriteLine("Saque realizado? " + saque);

        Console.WriteLine("Saldo da Luciana pós-saque: " + conta2.saldo);

        conta2.Depositar(60);

        Console.WriteLine("Saldo da Luciana pós-depósito " + conta2.saldo);


        //Console.WriteLine($"Titular : {conta.titular}");
        //Console.WriteLine($"Conta: {conta.conta}");
        //Console.WriteLine($"Número da agência: {conta.numero_agencia}");
        //Console.WriteLine($"Nome da Agencia: {conta.nome_agencia}");
        //.WriteLine($"Saldo: {conta.saldo}");


        /*Comparacao de saldo com o saldo da conta1 objeto
        double saldo = 100;
        double saldo2 = 100;
        Console.WriteLine(saldo == conta1.saldo); */


        Console.ReadKey();
    }
}


