public class Fantasma
{
    public string habilidade;
    public string cor;
    public string nick;
    public string movimento1;
    public string movimento2;

    public void GerarFantasma()
    {
        Console.WriteLine($"Este é sera seu fantasma {nick}, sua cor é {cor} e você terá a habilidade de {habilidade}.");
        Console.WriteLine($"Começou o jogo: {nick} se moveu para a {movimento1}, após isto, {nick} se moveu para {movimento2}");
    }
}

public class GerarFantasma
{
    public static void Main()
    {
        Fantasma p1 = new Fantasma();
        p1.habilidade = "Vida Extra";
        p1.cor = "Amarelo";
        p1.nick = "Paczin";
        p1.movimento1 = "direita";
        p1.movimento2 = "baixo";
        p1.GerarFantasma();
    }
}