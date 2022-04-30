using UnityEngine;

/// <summary>
/// Задает в текстовое поле колличество набранных очков
/// </summary>
public class ScoreTextView : AbstactTextView
{
    [SerializeField] private ScoreManager _scoreManager;

    protected override void Awake()
    {
        base.Awake();
        textMeshProUGUI.text = _scoreManager.Score.ToString();
    }

    private void OnEnable()
    {
        _scoreManager.OnScoreChange += OnScoreChange;
    }

    private void OnDisable()
    {
        _scoreManager.OnScoreChange -= OnScoreChange;
    }

    private void OnScoreChange(int score)
    {
        textMeshProUGUI.text = score.ToString();
    }
}