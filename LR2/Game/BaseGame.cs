
using LR2.GameAccount;

namespace LR2.Game
{
    public abstract class BaseGame
    {
        public int ID { get; protected set; }
        public int Rating { get; protected set; }

        protected static int GameCount = 1;

        public abstract int GetRating();
        public virtual void PlayGame(int rating, BaseAccount Player1, BaseAccount Player2)
        {
            if (Math.Max(Player1.CurrentRating, Player2.CurrentRating) < Rating-1 || Rating < 0)
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
                    Player2.LoseGame(this, Player1);
                }
                else
                {
                    Player2.WinGame(this, Player1);
                    Player1.LoseGame(this, Player2);
                }
            }
        }
    }
}