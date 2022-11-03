
namespace LR2.Game
{
    internal class GameFactory
    {
        public BaseGame CreateGame()
        {
            return new Game();
        }
        public BaseGame CreateRFGame()
        {
            return new RFGame();
        }
        public BaseGame CreateTrainingGame()
        {
            return new TrainingGame();
        }
    }
}
