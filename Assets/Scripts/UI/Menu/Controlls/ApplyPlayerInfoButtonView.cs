using UnityEngine;

/// <summary>
/// ������ ������������� ����� ���������� �� ������
/// </summary>
public class ApplyPlayerInfoButtonView : AbstactButtonView
{
    [SerializeField] private PlayerInfoController _playerInfoController;

    protected override void OnButtonClick()
    {
        _playerInfoController.ApplyPlayerInfo();
    }
}