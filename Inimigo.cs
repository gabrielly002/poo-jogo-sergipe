using System;

public class Inimigo : Entidade
{
    public string Tipo { get; set; }

    public Inimigo(string nome, int vida, int dano, string tipo)
        : base(nome, vida, dano)
    {
        Tipo = tipo;
    }

    public override void Atacar()
    {
        Console.WriteLine($"{Nome} atacou ferozmente no sertão!");
    }
}