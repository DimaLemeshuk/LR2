using LR2.Game;

namespace LR2.GameAccount
{
    public class Info
    { 
    public BaseAccount opponent { get; private set; }
    public int Rating { get; private set; }
    public int ID { get; private set; }
    public GameStatus status { get; private set; }
    public Info(int ID, int Rating, BaseAccount opponent, GameStatus status)
    {
        this.ID = ID;
        this.Rating = Rating;
        this.opponent = opponent;
        this.status = status;
    }
}
}
