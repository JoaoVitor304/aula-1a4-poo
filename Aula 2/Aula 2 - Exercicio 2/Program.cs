using System;

class Carro
{
    private string modelo;
    private int velocidadeAtual = 0;

    public Carro(string modelo)
    {
        this.modelo = modelo;
    }
    public void Acelerar(int valor)
    {
        if (valor > 0)
        {
            velocidadeAtual += valor;
        }
        else
        {
            Console.WriteLine("Velocidade não pode ficar abaixo de 0.");
            velocidadeAtual = 0;
        }
    }
    public void Frear(int valor)
    {
        velocidadeAtual -= valor;

        if(velocidadeAtual < 0)
        {
            Console.WriteLine("Velocidade não pode ficar abaixo de 0.");
            velocidadeAtual = 0;
        }
    }
    public void ExibirVelocidade()
    {
        Console.WriteLine($"O veiculo {modelo} está a {velocidadeAtual}km/h.");
    }
}
class Program
{
    static void Main()
    {
        Carro c = new Carro("Ferrari");
        c.Acelerar(40);
        c.Frear(20);
        c.Frear(50);
        c.ExibirVelocidade();
    }
}
