using UnityEngine;

/// <summary>
/// Контрллер UI в сцене игры
/// </summary>
public class UIController : MonoBehaviour
{
    [SerializeField] private GameObject _pausePanel;

    /// <summary>
    /// Показать панель паузы
    /// </summary>
    public void ShowPausePanel()
    {
        _pausePanel.SetActive(true);
    }

    /// <summary>
    /// Скрыть панель паузы
    /// </summary>
    public void HidePausePanel()
    {
        _pausePanel.SetActive(false);
    }
}