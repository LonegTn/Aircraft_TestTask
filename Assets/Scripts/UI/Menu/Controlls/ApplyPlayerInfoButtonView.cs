using UnityEngine;

/// <summary>
///  нопка подтверждени€ ввода информации об игроке
/// </summary>
public class ApplyPlayerInfoButtonView : AbstactButtonView
{
    [SerializeField] private PlayerInfoController _playerInfoController;

    protected override void OnButtonClick()
    {
        _playerInfoController.ApplyPlayerInfo();
    }
}