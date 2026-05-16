using System;

public class Player : Entidade

{

    public int Nivel { get; set; }

    public Player(string nome, int vida, int dano, int defesa, int nivel)

        : base(nome, vida, dano, defesa)

    {

        Nivel = nivel;

    }

    public override void Atacar()

    {

        Console.WriteLine($"{Nome} atacou com sua espada cangaceira!");

    }

    public void HabilidadeEspecial()

    {

        Console.WriteLine($"{Nome} usou o ataque especial do cangaço!");

    }

}