using System;

public class Inimigo : Entidade

{

    public string Tipo { get; set; } = "";

    public Inimigo(string nome, int vida, int dano, int defesa, string tipo)

        : base(nome, vida, dano, defesa)

    {

        Tipo = tipo;

    }

    public override void Atacar()

    {

        Console.WriteLine($"{Nome} atacou ferozmente!");

    }

}