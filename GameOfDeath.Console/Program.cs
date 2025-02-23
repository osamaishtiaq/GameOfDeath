// See https://aka.ms/new-console-template for more information

using GameOfDeath;

var player1 = new Player
{
    CardsCollection = new List<Card>(),
    CardsInDeck = new List<Card>(),
    CardsOnField = new List<Card>(),
    CurrentHealth = 5,
    Name = "Osama"
};

Console.WriteLine(player1.Name);