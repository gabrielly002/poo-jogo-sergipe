using System;

public abstract class Entidade
{
    private string nome;
    private int vida;
    private int dano;

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public int Vida
    {
        get { return vida; }
        set { vida = value; }
    }

    public int Dano
    {
        get { return dano; }
        set { dano = value; }
    }

    public Entidade(string nome, int vida, int dano)
    {
        Nome = nome;
        Vida = vida;
        Dano = dano;
    }

    public void ReceberDano(int valor)
    {
        Vida -= valor;

        Console.WriteLine($"{Nome} recebeu {valor} de dano!");
        Console.WriteLine($"Vida restante: {Vida}");
    }

    public abstract void Atacar();
}