using UnityEngine;

/// <summary>
/// ������ ����������� �����
/// </summary>
public class PauseButtonView : AbstactButtonView
{
    [SerializeField] private PlayerController _playerController;

    protected override void OnButtonClick()
    {
        _playerController.Pause();
    }
}
