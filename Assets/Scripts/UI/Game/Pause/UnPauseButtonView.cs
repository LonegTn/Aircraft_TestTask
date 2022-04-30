using UnityEngine;

/// <summary>
/// Кнопка снятия с паузы
/// </summary>
public class UnPauseButtonView : AbstactButtonView
{
    [SerializeField] private PlayerController _playerController;

    protected override void OnButtonClick()
    {
        _playerController.UnPause();
    }
}
