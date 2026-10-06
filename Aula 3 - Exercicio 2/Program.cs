using System;

class Pessoa
{
    public string Nome{get; private set;} = "";
    public int Idade{get; set;}
    public string Email{get; set;} = "";
}

class Program
{
    static void Main()
    {
        Pessoa pessoa = new Pessoa();
        pessoa.Nome = "João";
        pessoa.Idade = 19;
        pessoa.Email = "joao@gmail.com";

        Console.WriteLine($"Nome: {pessoa.Nome}");
        Console.WriteLine($"Idade: {pessoa.Idade}");
        Console.WriteLine($"Email: {pessoa.Email}");

        pessoa.Idade = 20;

        Console.WriteLine($"Nova idade: {pessoa.Idade}");
    }
}