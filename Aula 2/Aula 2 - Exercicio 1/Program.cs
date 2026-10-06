using System;

class Produto{
    private string nome;
    private decimal preco;

    public Produto(string nome, decimal preco)
    {
        this.nome = nome;

        if(preco >= 0)
        {
            this.preco = preco;
        }
        else
        {
            Console.WriteLine("O valor não pode ser negativo.");
            this.preco = 0;
        }
    }
    public void ExibirDetalhes()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Preço: {preco}");
    }
    public void AlterarPreco(decimal novopreco)
    {
        if(novopreco >= 0)
        {
            this.preco = novopreco;
        }
        else
        {
            Console.WriteLine("O valor não pode ser negativo.");
            this.preco = 0;
        }
    }
    public string GetNome()
    {
        return nome;
    }
    public decimal GetPreco()
    {
        return preco;
    }
}

class Program
{
     static void Main()
    {
        Produto p = new Produto("Notebook", 3000);
        p.ExibirDetalhes();
        p.AlterarPreco(-100);
        p.AlterarPreco(3500);
        p.ExibirDetalhes();
    }
}

