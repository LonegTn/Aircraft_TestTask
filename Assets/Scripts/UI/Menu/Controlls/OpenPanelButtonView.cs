using UnityEngine;

/// <summary>
/// ������ �������� ������ � �������� ����������
/// </summary>
public class OpenPanelButtonView : AbstactButtonView
{
    [SerializeField] private GameObject openableGameObject;
    [SerializeField] private GameObject closeGameObject;

    protected override void OnButtonClick()
    {
        openableGameObject.SetActive(true);
        closeGameObject.SetActive(false);
    }
}