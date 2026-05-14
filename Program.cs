using System;

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player(
            "Gato Cangaceiro",
            100,
            20,
            5
        );

        Inimigo inimigo = new Inimigo(
            "Coronel do Sertão",
            80,
            15,
            "Chefe"
        );

        player.Atacar();

        inimigo.ReceberDano(20);

        inimigo.Atacar();

        Console.ReadLine();
    }
}