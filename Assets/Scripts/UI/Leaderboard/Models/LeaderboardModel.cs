using System;

/// <summary>
/// ������ �������� ������� �������
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