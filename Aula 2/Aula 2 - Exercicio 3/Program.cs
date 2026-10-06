using System;

class Elevador
{
    private int andarAtual = 0;
    private int totalAndares; 

    public Elevador(int totalAndares)
    {
        this.totalAndares = totalAndares;
    }
    public void subir()
    {
        if(andarAtual + 1 > totalAndares)
        {
            Console.WriteLine($"O maximo de andares do predio é {totalAndares}.");
        }
        else
        {
            andarAtual += 1;
        }
    }
    public void descer()
    {
        if(andarAtual - 1 < 0)
        {
            Console.WriteLine($"O predio não possui andares abaixo de 0.");
        }
        else
        {
            andarAtual -= 1;
        }
    }
    public void ExibirAndar()
    {
        Console.WriteLine($"Você está no andar {andarAtual}.");
    }
}

class Program
{
    static void Main()
    {
        Elevador e = new Elevador(3);
        e.subir();
        e.subir();
        e.ExibirAndar();
        e.descer();
        e.ExibirAndar();
        e.descer();
        e.descer();
        e.ExibirAndar();
    }
}

