using UnityEngine;

/// <summary>
/// ������ ������ � �����
/// </summary>
public class UnPauseButtonView : AbstactButtonView
{
    [SerializeField] private PlayerController _playerController;

    protected override void OnButtonClick()
    {
        _playerController.UnPause();
    }
}
