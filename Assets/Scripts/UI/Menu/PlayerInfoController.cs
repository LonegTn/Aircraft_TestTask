using TMPro;
using UnityEngine;

/// <summary>
/// ���������� ���������� �� ������
/// </summary>
public class PlayerInfoController : MonoBehaviour
{
    [SerializeField] private TMP_InputField _nameInputField;

    /// <summary>
    /// ����������� ���� ���������� �� ������
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