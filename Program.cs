/*
En spiller har et navn og et antall poeng. 
Når to spiller mot hverandre, vil den ene miste et poeng og den andre få et poeng. 

Koden under simulerer tre spillere med 10 poeng hver - og ti runder hvor to tilfeldige av dem spiller mot hverandre. 
Lag klassen Player, slik at koden under fungerer:

var random = new Random();
var players = new[] { new Player("Per", 10), new Player("Pål", 10), new Player("Espen", 10) };
for (var round = 1; round <= 10; round++)
{
    var playerIndex1 = random.Next(players.Length);
    var playerIndex2 = (playerIndex1 + 1 + random.Next(2)) % players.Length;
    var player1 = players[playerIndex1];
    var player2 = players[playerIndex2];
    player1.Play(player2);
}

foreach (var player in players)
{
    player.ShowNameAndPoints();
}
*/


using System.Numerics;

namespace Players
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Playing();
        }

        public static void Playing()
        {
            var random = new Random();

            var players = new[]
                { 
                    new Player("Per", 10),
                    new Player("Pål", 10),
                    new Player("Espen", 10)
                 };

            for(var round = 1; round <= 10; round++)
            {
                var playerIndex1 = random.Next(players.Length);
                var playerIndex2 = (playerIndex1 + 1 + random.Next(2)) % players.Length;

                var player1 = players[playerIndex1];
                var player2 = players[playerIndex2];

                player1.Play(player2);
            }

            // Funksjonalitet for å bestemme hvem som vant totalt

            Player winner = null!;
            var maxPoints = int.MinValue;

            foreach(var player in players)
            {
                player.ShowNameAndPoints();

                if (player.Points > maxPoints)
                {
                    maxPoints = player.Points;
                    winner = player;
                }
            }

            if (winner != null)
            {
                Console.WriteLine($"\nVinneren av turneringen er {winner.Name} med {winner.Points} poeng!");
            }

        }
    }
}