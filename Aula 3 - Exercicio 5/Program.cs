using System;
using System.Data.Common;

class contaBancaria
{
    public string Titular;
    public double Saldo {get; private set;} = 0;

    public contaBancaria(string titular)
    {
        Titular = titular;
    }

    public void Depositar(double valor)
    {
        if(valor > 0)
        {
            Saldo += valor;
        }
        else
        {
            Console.WriteLine("Valor não pode ser negativo.");
        }
    }

    public void Sacar(double valor)
    {
        if(valor <= 0)
        {
            Console.WriteLine("O valor de saque não pode ser negativo.");
        }
        else if(valor > Saldo)
        {
            Console.WriteLine("Saldo Insuficiente.");
        }
        else
        {
            Saldo -= valor;
        }
    }
}

class Program
{
    static void Main()
    {
        contaBancaria conta = new contaBancaria("João");

        conta.Depositar(1000);
        conta.Sacar(250);

        Console.WriteLine(conta.Saldo);
    }
}