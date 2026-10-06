using System;

class ContaBancaria
{
    private decimal saldo = 1000;

    public decimal Saldo
    {
        get
        {
            return saldo;
        }
    }
}

class Program
{
    static void Main()
    {
        ContaBancaria conta = new ContaBancaria();
        Console.WriteLine(conta.Saldo);
    }
}

// conta.Saldo executa o get, que devolve o valor do campo saldo