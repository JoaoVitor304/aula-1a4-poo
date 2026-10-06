using System.Globalization;

public class Pessoa
{
    public string Nome;
    public int Idade;
    public string Cargo;

    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos");
    }

    public double Salario()
    {
        if (Cargo == "Suporte N1")
        return 3500;

        else if (Cargo == "Gerente")
        return 10000;

        else if (Cargo == "Desenvolvedor")
        return 5000;

        else if (Cargo == "Estagiario")
        return 100;

        return 0;
    }
}

public class Program
{
    public static void Main()
    {
        Pessoa p1 = new Pessoa();
        p1.Idade = 19;
        p1.Nome = "João Vitor";
        p1.Cargo = "Suporte N1";
        p1.Apresentar();
        Console.WriteLine($"Salário: R$ {p1.Salario():F2}");

        Pessoa p2 = new Pessoa();
        p2.Idade = 30;
        p2.Nome = "José";
        p2.Cargo = "Gerente";
        p2.Apresentar();
        Console.WriteLine($"Salário: R$ {p2.Salario():F2}");

        Pessoa p3 = new Pessoa();
        p3.Idade = 42;
        p3.Nome = "Pedro";
        p3.Cargo = "Desenvolvedor";
        p3.Apresentar();
        Console.WriteLine($"Salário: R$ {p3.Salario():F2}");

        Pessoa p4 = new Pessoa();
        p4.Idade = 20;
        p4.Nome = "Lucas";
        p4.Cargo = "Estagiario";
        p4.Apresentar();
        Console.WriteLine($"Salário: R$ {p4.Salario():F2}");
    }
}