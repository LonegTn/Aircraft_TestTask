using System.Collections.Generic;
using System.IO;
using UnityEngine;
using static System.Linq.Enumerable;

/// <summary>
/// Сохранение и загрузка данных в PlayerPrefs
/// </summary>
public static class SaveController
{
    /// <summary>
    /// Сохранить данные
    /// </summary>
    public static void Save<T>(string prefsKey, List<T> models)
    {
        PlayerPrefs.SetString(prefsKey, JsonHelper.ToJson(models.ToArray(), true));
    }

    /// <summary>
    /// Загрузить данные
    /// </summary>
    public static List<T> Load<T>(string prefsKey)
    {
        if (PlayerPrefs.HasKey(prefsKey))
        {
            string content = PlayerPrefs.GetString(prefsKey);
            T[] jsonContent = JsonHelper.FromJson<T>(content);
            if (jsonContent != null)
            {
                return jsonContent.ToList();
            }
        }
        return new List<T>();
    }
}