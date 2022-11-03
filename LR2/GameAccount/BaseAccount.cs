using LR2.Game;

namespace LR2.GameAccount
{
    public abstract class BaseAccount
    {
        public string UserName { get; set; }
        public int CurrentRating { get; protected set; }
        public int GameCount
        {
            get { return History.Count; }
        }

        public List<Info> History = new List<Info>();

        public BaseAccount(string UserName)
        {
            this.UserName = UserName;
            CurrentRating = 1;
        }

        public abstract void WinGame(BaseGame Game, BaseAccount opponent);

        public abstract void LoseGame(BaseGame Game, BaseAccount opponent);
       
        public static void GetHistory(List<Info> History)
        {
            foreach (var info in History)
            {
                Console.WriteLine($"Iндекс гри: {info.ID} Противник: {info.opponent.UserName} Рейтинг:{info.Rating} Статус:{info.status}");
            }
        }
        public void GetStatus()
        {
            Console.WriteLine("Статистика гравця " + UserName + " : ");
            BaseAccount.GetHistory(this.History);
            Console.WriteLine($"Кiлькiсть зiграних iгор:{GameCount}\tРейтинг:{CurrentRating}\n");
        }

    }
}
