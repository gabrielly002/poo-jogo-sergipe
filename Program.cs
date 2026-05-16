using System;

class Program

{

    static void Main(string[] args)

    {

        Console.WriteLine("=================================");

        Console.WriteLine("        BATALHA NO SERTÃO");

        Console.WriteLine("=================================\n");

        Player player = new Player(

            "Gato Cangaceiro",

            100,

            20,

            5,

            3

        );

        Inimigo inimigo = new Inimigo(

            "Coronel do Sertão",

            80,

            15,

            2,

            "Chefe"

        );

        Console.WriteLine("Gato Cangaceiro encontrou o Coronel do Sertão!\n");

        player.Atacar();

        inimigo.ReceberDano(player.Dano);

        Console.WriteLine($"Vida do Coronel do Sertão: {inimigo.Vida}\n");

        inimigo.Atacar();

        player.ReceberDano(inimigo.Dano);

        Console.WriteLine($"Vida do Gato Cangaceiro: {player.Vida}\n");

        player.HabilidadeEspecial();

        Console.WriteLine("\nCoronel do Sertão foi derrotado!");

        Console.WriteLine("\n=================================");

        Console.WriteLine("            VITÓRIA");

        Console.WriteLine("=================================");

        Console.ReadLine();

    }

}