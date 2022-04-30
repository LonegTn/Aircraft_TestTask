using System;
using UnityEngine;

/// <summary>
/// ����������� ���������� �����
/// </summary>
public abstract class AbstractInputManager : MonoBehaviour
{
    public abstract event Action<Vector3> OnClick;

    protected bool _externalInputBlocker;

    /// <summary>
    /// ������������� ����
    /// </summary>
    public void GainControl()
    {
        _externalInputBlocker = true;
    }

    /// <summary>
    /// �������������� ����
    /// </summary>
    public void ReleaseControl()
    {
        _externalInputBlocker = false;
    }
}