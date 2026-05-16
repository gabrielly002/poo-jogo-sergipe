using System;

public abstract class Entidade

{

    private string nome = "";

    private int vida;

    private int dano;

    private int defesa;

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

    public int Defesa

    {

        get { return defesa; }

        set { defesa = value; }

    }

    public Entidade(string nome, int vida, int dano, int defesa)

    {

        Nome = nome;

        Vida = vida;

        Dano = dano;

        Defesa = defesa;

    }

    public void ReceberDano(int valor)

    {

        int danoFinal = valor - Defesa;

        if (danoFinal < 0)

        {

            danoFinal = 0;

        }

        Vida -= danoFinal;

        Console.WriteLine($"{Nome} recebeu {danoFinal} de dano!");

    }

    public void MostrarStatus()

    {

        Console.WriteLine("==========");

        Console.WriteLine($"Nome: {Nome}");

        Console.WriteLine($"Vida: {Vida}");

        Console.WriteLine($"Dano: {Dano}");

        Console.WriteLine($"Defesa: {Defesa}");

        Console.WriteLine("==========");

    }

    public abstract void Atacar();
}