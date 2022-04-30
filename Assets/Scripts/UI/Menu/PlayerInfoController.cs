using TMPro;
using UnityEngine;

/// <summary>
/// Контроллер информации об игроке
/// </summary>
public class PlayerInfoController : MonoBehaviour
{
    [SerializeField] private TMP_InputField _nameInputField;

    /// <summary>
    /// Подтвердить ввод информации об игроке
    /// </summary>
    public void ApplyPlayerInfo()
    {
        PlayerInfoModel playerInfoModel = new PlayerInfoModel();
        playerInfoModel.Name = _nameInputField.text;

        PlayerInfo.PlayerInfoModel = playerInfoModel;
    }

    private void Awake()
    {
        LoadPlayerInfo();
    }

    private void LoadPlayerInfo()
    {
        if (PlayerInfo.PlayerInfoModel != null)
        {
            _nameInputField.text = PlayerInfo.PlayerInfoModel.Name;
        }
    }
}