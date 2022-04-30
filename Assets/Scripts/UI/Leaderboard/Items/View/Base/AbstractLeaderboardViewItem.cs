using TMPro;
using UnityEngine;

/// <summary>
/// Абстрактное представление итема в модели таблицы лидеров
/// </summary>
[RequireComponent(typeof(TextMeshProUGUI))]
public abstract class AbstractLeaderboardViewItem : MonoBehaviour
{
    [SerializeField] private LeaderboardViewItemController viewItemController;

    protected TextMeshProUGUI textMeshPro;

    protected virtual void Awake()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
        OnLeaderboardModelChange(viewItemController.LeaderboardViewModel);
    }

    protected virtual void OnEnable()
    {
        viewItemController.OnLeaderboardModelChange += OnLeaderboardModelChange;
    }

    protected virtual void OnDisable()
    {
        viewItemController.OnLeaderboardModelChange -= OnLeaderboardModelChange;
    }
    protected abstract void OnLeaderboardModelChange(LeaderboardViewModel viewModel);
}