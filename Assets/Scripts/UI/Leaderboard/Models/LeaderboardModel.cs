using System;

/// <summary>
/// Модель сущности таблицы лидеров
/// </summary>
[Serializable]
public class LeaderboardModel
{
    public string Name;
    public int Score;

    public LeaderboardModel(string name, int score)
    {
        Name = name;
        Score = score;
    }
}