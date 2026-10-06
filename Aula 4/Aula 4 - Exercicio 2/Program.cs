using System;

class Pessoa
{
    public string Nome;
}

class Casa
{
    public Pessoa Morador;
    public void ExibirMorador()
    {
        Console.WriteLine($"Nome do morador: {Morador.Nome}");
    }
}

class Program
{
    static void Main()
    {
        Pessoa pessoa = new Pessoa();
        pessoa.Nome = "João";
        
        Casa casa = new Casa();
        casa.Morador = pessoa;
        casa.ExibirMorador();
    }
}