using UnityEngine;

/// <summary>
/// ��������� UI � ����� ����
/// </summary>
public class UIController : MonoBehaviour
{
    [SerializeField] private GameObject _pausePanel;

    /// <summary>
    /// �������� ������ �����
    /// </summary>
    public void ShowPausePanel()
    {
        _pausePanel.SetActive(true);
    }

    /// <summary>
    /// ������ ������ �����
    /// </summary>
    public void HidePausePanel()
    {
        _pausePanel.SetActive(false);
    }
}