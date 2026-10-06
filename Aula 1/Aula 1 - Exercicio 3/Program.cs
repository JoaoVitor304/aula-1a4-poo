public class Produto
{
    public string nome;
    public int quantidade;
    public double preço;

    public void ExibirDados()
    {
        Console.WriteLine($"Os produtos disponiveis são: {nome} - {quantidade}un - R${preço}.");
    }

    public void CalcularValorTotal()
    {
        Console.WriteLine($"O valor total dos produtos é:{preço * quantidade}");
    }
}

public class Program
{
    public static void Main()
    {
        Produto p1 = new Produto();
        p1.nome = "Ferro";
        p1.quantidade = 100;
        p1.preço = 70.00;
        p1.ExibirDados();
        p1.CalcularValorTotal();

        Produto p2 = new Produto();
        p2.nome = "Ouro";
        p2.quantidade = 50;
        p2.preço = 700.00;  
        p2.ExibirDados();
        p2.CalcularValorTotal();

        Produto p3 = new Produto();
        p3.nome = "Safira";
        p3.quantidade = 20;
        p3.preço = 1500.00;  
        p3.ExibirDados();
        p3.CalcularValorTotal();
    }
}