using System;

public interface IVeiculo
{
    void Mover();
}

class Carro : IVeiculo
{
    public void Mover()
    {
        Console.WriteLine("O carro está se movendo.");
    }
}
class Bicicleta : IVeiculo
{
    public void Mover()
    {
        Console.WriteLine("A bicicleta está se movendo.");
    }
}

class Program
{
    static void Main()
    {
        IVeiculo carro = new Carro();
        IVeiculo bicicleta = new Bicicleta();

        carro.Mover();
        bicicleta.Mover();
    }
}