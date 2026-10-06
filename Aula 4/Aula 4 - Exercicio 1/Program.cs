using System;

class Veiculos
{
    public string Marca;
    public string Modelo;
    public int NumeroDeRodas;

    public void ExibirDados()
    {
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Numero de Rodas: {NumeroDeRodas}");
    }
}

class Carro : Veiculos
{
    public int NumeroDePortas;
}
class Moto : Veiculos
{
    public bool PossuiBagageiro;
}

class Program
{
    static void Main()
    {
        Carro carro = new Carro();
        carro.Marca = "Fiat";
        carro.Modelo = "Palio";
        carro.NumeroDeRodas = 4;
        carro.NumeroDePortas = 2;

        Moto moto = new Moto();
        moto.Marca = "Fazer";
        moto.Modelo = "FZ25";
        moto.NumeroDeRodas = 2;
        moto.PossuiBagageiro = false;

        carro.ExibirDados();
        Console.WriteLine($"Numero de Portas: {carro.NumeroDePortas}.");

        moto.ExibirDados();
        Console.WriteLine($"Possui bagageiro: {moto.PossuiBagageiro}");
    }
}