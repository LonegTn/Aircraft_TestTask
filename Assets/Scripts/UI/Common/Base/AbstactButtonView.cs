using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// ���������� ����� ��� ���������� Button
/// </summary>
[RequireComponent(typeof(Button))]
public abstract class AbstactButtonView : MonoBehaviour
{
    protected Button buttonView;

    protected virtual void Awake()
    {
        buttonView = GetComponent<Button>();
    }

    protected virtual void OnEnable()
    {
        buttonView.onClick.AddListener(OnButtonClick);
    }

    protected virtual void OnDisable()
    {
        buttonView.onClick.RemoveListener(OnButtonClick);
    }

    /// <summary>
    /// �������� ��� ����� �� ������
    /// </summary>
    protected abstract void OnButtonClick();
}