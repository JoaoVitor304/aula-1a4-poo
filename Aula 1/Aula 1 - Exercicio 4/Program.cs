public class Conta
{
    public string titular;
    public int numeroconta;
    public double saldo;

    public void Sacar(double valor)
    {
        if (valor <= saldo)
        {
            saldo -= valor;
            Console.WriteLine($"Saque no valor de R${valor} realizado com sucesso!");
        }
        else if (valor > saldo)
        {
            Console.WriteLine($"Saldo insuficiente.");
        }
    }
    public void Depositar(double valor)
    {
        if (valor > 0)
        {
            saldo += valor;
            Console.WriteLine($"Deposito no valor de R${valor} realizado com sucesso!");
        }
        else
        {
            Console.WriteLine($"O valor de deposito deve ser maior que 0.");
        }
    }
    public void ExibirSaldo()
    {
        Console.WriteLine($"Titular: {titular}.");
        Console.WriteLine($"Numero da conta: {numeroconta}.");
        Console.WriteLine($"Saldo: {saldo}.");
    }
}

public class Program
{
    public static void Main()
    {
        Conta p1 = new Conta();
        p1.titular = "João";
        p1.numeroconta = 102030;
        p1.saldo = 1000;
        p1.Depositar(100);
        p1.Sacar(200);
        p1.ExibirSaldo();

        Conta p2 = new Conta();
        p2.titular = "José";
        p2.numeroconta = 405060;
        p2.saldo = 50000;
        p2.Depositar(500);
        p2.Sacar(60000);
        p2.ExibirSaldo();
    }
}