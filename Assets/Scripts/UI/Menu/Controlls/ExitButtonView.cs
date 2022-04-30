using UnityEngine;

/// <summary>
/// Выход из игры
/// </summary>
public class ExitButtonView : AbstactButtonView
{
    protected override void OnButtonClick()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }
}