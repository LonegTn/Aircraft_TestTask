using TMPro;
using UnityEngine;

/// <summary>
/// ���������� ����� ��� ���������� TextMeshProUGUI
/// </summary>
[RequireComponent(typeof(TextMeshProUGUI))]
public class AbstactTextView : MonoBehaviour
{
    protected TextMeshProUGUI textMeshProUGUI;

    protected virtual void Awake()
    {
        textMeshProUGUI = GetComponent<TextMeshProUGUI>();
    }
}