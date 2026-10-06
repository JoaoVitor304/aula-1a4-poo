using System;

class Produto
{
    private string nome;
    private string cod;
    private double preco;
    private int qnt_estoque;
    private bool estoque_baixo;

    public Produto(string nome)
    {
        Nome = nome;
    }
    public string Nome
    {
        get => nome;
        set
        {
            if(string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("Nome não pode ser vazio.");
            nome = value;
        }
    }

    public string Cod
    {
        get => cod;
        set
        {
            if(string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("Codigo não pode ser vazio.");
            cod = value;
        }
    }

    public double Preco
    {
        get => preco;
        set
        {
            if(value < 0)
            throw new ArgumentException("O preço não pode ser negativo.");
            preco = value;
        }
    }

    public int Qnt_Estoque
    {
        get => qnt_estoque;
    }

    public void AdicionarEstoque(int quantidade)
    {
        qnt_estoque += quantidade;
    }
    public void RemoverEstoque(int quantidade)
    {
        if(quantidade > qnt_estoque)
        {
            Console.WriteLine("Estoque Insuficiente");
            return;
        }
        qnt_estoque -= quantidade;
    }

    public bool Estoque_Baixo()
    {
        return qnt_estoque <= 5;
    }
}

class Program
{
    public static void Main()
    {
        Produto produto = new Produto("Mochila");

        produto.AdicionarEstoque(20);
        Console.WriteLine(produto.Qnt_Estoque);

        produto.RemoverEstoque(10);
        Console.WriteLine(produto.Qnt_Estoque);

        Console.WriteLine(produto.Estoque_Baixo());

        produto.Qnt_Estoque = 500;
    }
}