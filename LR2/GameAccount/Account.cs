using LR2.Game;

namespace LR2.GameAccount
{
    public class Account : BaseAccount
    {
        public Account(string UserName)
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
                CurrentRating -= rating;
            }
            Info info = new Info(Game.ID, rating, opponent, GameStatus.Lose);
            History.Add(info);
        }
        public override void WinGame(BaseGame Game, BaseAccount opponent)
        {
            int rating = Game.GetRating();
           
            CurrentRating += rating;
            Info info = new Info(Game.ID, rating, opponent, GameStatus.Victory);
            History.Add(info);
        }
    }
}
