using System;
interface IVoar
{
    void Voar();
}
interface INadar
{
    void Nadar();
}

class Pato : IVoar, INadar
{
    public void Voar()
    {
        Console.WriteLine("O Pato voa.");
    }
    public void Nadar()
    {
        Console.WriteLine("O Pato nada.");
    }
}

class Aguia : IVoar
{
    public void Voar()
    {
        Console.WriteLine("A Aguia pode voar.");
    }
}

class Peixe : INadar
{
    public void Nadar()
    {
        Console.WriteLine("O peixe nada");
    }
}

class Program
{
    public static void Main()
    {
        Pato pato = new Pato();
        pato.Nadar();
        pato.Voar();

        Aguia aguia = new Aguia();
        aguia.Voar();

        Peixe peixe = new Peixe();
        peixe.Nadar();
    }
}