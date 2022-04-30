using System;
using UnityEngine;

/// <summary>
/// Абстрактный контроллер ввода
/// </summary>
public abstract class AbstractInputManager : MonoBehaviour
{
    public abstract event Action<Vector3> OnClick;

    protected bool _externalInputBlocker;

    /// <summary>
    /// Заблокировать ввод
    /// </summary>
    public void GainControl()
    {
        _externalInputBlocker = true;
    }

    /// <summary>
    /// Разблокировать ввод
    /// </summary>
    public void ReleaseControl()
    {
        _externalInputBlocker = false;
    }
}