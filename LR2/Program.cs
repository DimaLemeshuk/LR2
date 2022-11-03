using LR2.GameAccount;
using LR2.Game;

namespace LR2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var Player1 = new VIPAccount("Vasyl");
            var Player2 = new VIPAccount("Ivan");
            var Player3 = new VIPAccount("Stas");
            var Player4 = new Account("Vlad");
            var Player5 = new ConfinedAccount("Peter");

            var GameFactory = new GameFactory();
            BaseGame Game1 = GameFactory.CreateGame(); 
            Game1.PlayGame(1, Player1, Player2);
            Game1.PlayGame(1, Player2, Player3);
            Game1.PlayGame(1, Player3, Player4);
            Game1.PlayGame(1, Player4, Player5);
            Game1.PlayGame(2, Player1, Player2);
            Game1.PlayGame(3, Player2, Player3);
            Game1.PlayGame(2, Player3, Player4);
            Game1.PlayGame(1, Player4, Player5);

            BaseGame Game2 = GameFactory.CreateRFGame();
            Game2.PlayGame(2, Player1, Player2);
            Game2.PlayGame(2, Player3, Player2);
            Game2.PlayGame(1, Player5, Player3);
            
            BaseGame Game3 = GameFactory.CreateTrainingGame();
            Game3.PlayGame(1, Player1, Player2);
            Game3.PlayGame(1, Player1, Player2);
            Game3.PlayGame(1, Player1, Player2);
            Game3.PlayGame(1, Player1, Player2);

            Player1.GetStatus();
            Player2.GetStatus();
            Player3.GetStatus();
            Player4.GetStatus();
            Player5.GetStatus();


        }
    }
}