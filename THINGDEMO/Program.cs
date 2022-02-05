using THING.GAME;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



Game game = new Game();

game.PlayerAdd("Anton");
game.PlayerAdd("Petr");
game.PlayerAdd("Slavik"); 
game.PlayerAdd("Ifan");
game.Start();



//game.SwapCard(0, 1, 1, 1);
foreach (Card item in game.gameBoard[1].Deck)
{
    Console.WriteLine(item.Name);
}
Console.WriteLine();
int i = 0;

    while (true)
{
    game.DrawCard(0);
    if (game.gameBoard[0].Deck.Count == 5) { game.DropCard(0, 0); }
    Console.WriteLine(i);
    foreach (Card item in game.gameBoard[0].Deck)
    {
        int number = 2;
        Console.WriteLine($"№ {number}  {item.Name}");
        number++;
    }
    Console.WriteLine();
    //Console.ReadLine();
    i++;
}


foreach (Player player in game.gameBoard)
{

    Console.WriteLine(player.Name);
    foreach (Card item in player.Deck)
    {
        Console.WriteLine(item.Name);
    }
    Console.WriteLine();

}


