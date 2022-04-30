using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Контроллер всех воздушных шаров на сцене
/// </summary>
public class BallonsController : MonoBehaviour
{
    [SerializeField] private BallonsSpawnManager _ballonsSpawnManager;

    /// <summary>
    /// Поставить на паузу
    /// </summary>
    public void Pause()
    {
        _ballonsSpawnManager.Pause();
        List<Ballon> ballons = _ballonsSpawnManager.BallonsPool.GetAllBallons();
        ballons.ForEach(ballon => ballon.Pause());
    }

    /// <summary>
    /// Снять с паузы
    /// </summary>
    public void UnPause()
    {
        _ballonsSpawnManager.UnPause();
        List<Ballon> ballons = _ballonsSpawnManager.BallonsPool.GetAllBallons();
        ballons.ForEach(ballon => ballon.UnPause());
    }
}