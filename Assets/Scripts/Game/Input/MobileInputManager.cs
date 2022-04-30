using System;
using UnityEngine;

/// <summary>
/// Контроллер ввода на мобильном устройстве
/// </summary>
public class MobileInputManager : AbstractInputManager
{
    public override event Action<Vector3> OnClick = delegate { };

    private void Update()
    {
        if (_externalInputBlocker)
        {
            return;
        }

        if (Input.touchCount > 0)
        {
            for (int i = 0; i < Input.touchCount; i++)
            {
                Touch touch = Input.GetTouch(i);
                if (touch.phase == TouchPhase.Began)
                {
                    OnClick.Invoke(touch.position);
                }
            }
        }
    }
}