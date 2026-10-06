using System;

class Retangulo
{
    public int Largura;
    public int Altura;
    public int Area
    {
        get {return Largura * Altura;}
    }
}
class Program
{
    static void Main()
    {
        Retangulo retangulo = new Retangulo();
        
        retangulo.Largura = 10;
        retangulo.Altura = 5;

        Console.WriteLine(retangulo.Area);
    }
}