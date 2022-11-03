
using LR2.GameAccount;

namespace LR2.Game
{
    internal class RFGame : BaseGame
    {
        public override int GetRating()
        {
            return Rating;
        }
        public override void PlayGame(int rating, BaseAccount Player1, BaseAccount Player2)
        {
            if (Math.Max(Player1.CurrentRating, Player2.CurrentRating) < Rating || Rating < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(Rating));
            }
            else
            {
                Rating = rating;
                this.ID = GameCount;
                GameCount++;
                Random random = new Random();
                if (random.Next(0, 10) < 5)
                {
                    Player1.WinGame(this, Player2);
                }
                else
                {
                    Player1.LoseGame(this, Player2);
                }
            }
        }
    }
}

