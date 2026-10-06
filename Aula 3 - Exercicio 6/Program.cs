using System;

class Aluno
{
    private string nome;
    private double nota1;
    private double nota2; 

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

    public double Nota1
    {
        get => nota1;
        set
        {
            if(value < 0 || value > 10)
            throw new ArgumentOutOfRangeException(nameof(value),"Nota deve estar entre 0 e 10.");
            nota1 = value;
        }
    }

    public double Nota2
    {
        get => nota2;
        set
        {
            if(value < 0 || value > 10)
            throw new ArgumentOutOfRangeException(nameof(value),"Nota deve estar entre 0 e 10.");
            nota2 = value;
        }
    }

    public double Media => (Nota1 + Nota2) / 2;
}
class Program
{
    static void Main()
    {
        Aluno aluno = new Aluno();
        aluno.Nome = "João";
        aluno.Nota1 = 8;
        aluno.Nota2 = 6;

        Console.WriteLine(aluno.Media);

        aluno.Nota2 = 10;

        Console.WriteLine(aluno.Media);
    }
}