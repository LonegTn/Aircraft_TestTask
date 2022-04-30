using UnityEngine;

/// <summary>
///  нопка выставлени€ паузы
/// </summary>
public class PauseButtonView : AbstactButtonView
{
    [SerializeField] private PlayerController _playerController;

    protected override void OnButtonClick()
    {
        _playerController.Pause();
    }
}
