using UnityEngine;

/// <summary>
/// Информация об игроке
/// </summary>
public static class PlayerInfo
{
    private static PlayerInfoModel playerInfoModel;
    public static PlayerInfoModel PlayerInfoModel
    {
        get
        {
            if (playerInfoModel == null)
            {
                LoadPlayerInfo();
            }
            return playerInfoModel;
        }
        set
        {
            if (value != null)
            {
                playerInfoModel = value;
                SavePlayerInfo();
            }
        }
    }

    private const string PLAYER_INFO_PREFS_KEY = "player_info";

    private static void SavePlayerInfo()
    {
        string playerInfoStr = JsonUtility.ToJson(playerInfoModel);
        PlayerPrefs.SetString(PLAYER_INFO_PREFS_KEY, playerInfoStr);
    }

    private static void LoadPlayerInfo()
    {
        if (PlayerPrefs.HasKey(PLAYER_INFO_PREFS_KEY))
        {
            string playerInfoStr = PlayerPrefs.GetString(PLAYER_INFO_PREFS_KEY);
            playerInfoModel = JsonUtility.FromJson<PlayerInfoModel>(playerInfoStr);
        }
    }
}