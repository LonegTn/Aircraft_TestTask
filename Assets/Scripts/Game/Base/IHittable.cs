using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHittable
{
    /// <summary>
    /// Логика при попадании
    /// </summary>
    bool Hit();
}