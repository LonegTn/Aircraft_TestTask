using System;
using UnityEngine;

/// <summary>
/// Контроллер набранных очков
/// </summary>
public class ScoreManager : MonoBehaviour
{
    public event Action<int> OnScoreChange = delegate { };

    private int _score;
    public int Score => _score;

    /// <summary>
    /// Добавить очки
    /// </summary>
    public void AddScore(int value)
    {
        _score += value;
        OnScoreChange(_score);
    }
}