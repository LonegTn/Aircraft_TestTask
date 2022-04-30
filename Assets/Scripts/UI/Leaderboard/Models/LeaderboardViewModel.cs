/// <summary>
/// Модель представления сущности таблицы лидеров
/// </summary>
public class LeaderboardViewModel
{
    public int Place { get; private set; }
    public string Name { get; private set; }
    public int Score { get; private set; }

    public LeaderboardViewModel(int place, string name, int score)
    {
        Place = place;
        Name = name;
        Score = score;
    }
}