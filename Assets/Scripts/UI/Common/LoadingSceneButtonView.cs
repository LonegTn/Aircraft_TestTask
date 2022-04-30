using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
///  нопка загрузки заданной сцены
/// </summary>
public class LoadingSceneButtonView : AbstactButtonView
{
    [SerializeField] private string nextSceneName;

    protected override void OnButtonClick()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}