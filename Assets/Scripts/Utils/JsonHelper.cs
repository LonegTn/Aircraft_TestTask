using System;
using UnityEngine;

/// <summary>
/// Хелпер для работы с массивами в JSON
/// </summary>
public static class JsonHelper
{
    /// <summary>
    /// Получить массив из JSON
    /// </summary>
    public static T[] FromJson<T>(string json)
    {
        Wrapper<T> wrapper = JsonUtility.FromJson<Wrapper<T>>(json);
        return wrapper.Items;
    }

    /// <summary>
    /// Положить массив из JSON
    /// </summary>
    public static string ToJson<T>(T[] array, bool prettyPrint)
    {
        Wrapper<T> wrapper = new Wrapper<T>();
        wrapper.Items = array;
        return JsonUtility.ToJson(wrapper, prettyPrint);
    }

    [Serializable]
    private class Wrapper<T>
    {
        public T[] Items;
    }
}
