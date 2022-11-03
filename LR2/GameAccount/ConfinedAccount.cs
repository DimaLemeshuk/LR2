
using LR2.Game;

namespace LR2.GameAccount
{
    internal class ConfinedAccount : BaseAccount
    {
        public ConfinedAccount(string UserName)
            : base(UserName)
        {
        }
        public override void LoseGame(BaseGame Game, BaseAccount opponent)
        {
            int rating = Game.GetRating();
            if (CurrentRating - rating < 1)
            {
                CurrentRating = 1;
            }
            else
            {
                CurrentRating -= (int)(rating * 1.5);
            }
            Info info = new Info(Game.ID, rating, opponent, GameStatus.Lose);
            History.Add(info);
        }

        public override void WinGame(BaseGame Game, BaseAccount opponent)
        {
            int rating = Game.GetRating();
            CurrentRating += (int)(rating * 0.7);
            Info info = new Info(Game.ID, rating, opponent, GameStatus.Victory);
            History.Add(info);
        }
    }
}
