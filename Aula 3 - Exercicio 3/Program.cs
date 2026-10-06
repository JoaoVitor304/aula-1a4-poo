using System;

class Produto
{
    private decimal preco;

    public decimal Preco
    {
        get
        {
            return preco;
        }

        set
        {
            if(value < 0)
            {
                throw new ArgumentException("O preço não pode ser negativo.");
            }

            preco = value;
        }
    }
}

class Program
{
    static void Main()
    {
        Produto produto = new Produto();

        try
        {
            produto.Preco = 100;
            Console.WriteLine($"Preço: {produto.Preco}");

            produto.Preco = 250;
            Console.WriteLine($"Preço: {produto.Preco}");

            produto.Preco = -50;
        }
        catch(ArgumentException erro)
        {
            Console.WriteLine($"Erro: {erro.Message}");
        }
    }
}