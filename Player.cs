using System;

public class Player : Entidade
{
    public int Nivel { get; set; }

    public Player(string nome, int vida, int dano, int nivel)
        : base(nome, vida, dano)
    {
        Nivel = nivel;
    }

    public override void Atacar()
    {
        Console.WriteLine($"{Nome} atacou usando a espada cangaceira!");
    }
}