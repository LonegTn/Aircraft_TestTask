using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// ������ �������� �������� �����
/// </summary>
public class LoadingSceneButtonView : AbstactButtonView
{
    [SerializeField] private string nextSceneName;

    protected override void OnButtonClick()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}