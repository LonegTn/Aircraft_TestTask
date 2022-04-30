using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ���������� ���� ��������� ����� �� �����
/// </summary>
public class BallonsController : MonoBehaviour
{
    [SerializeField] private BallonsSpawnManager _ballonsSpawnManager;

    /// <summary>
    /// ��������� �� �����
    /// </summary>
    public void Pause()
    {
        _ballonsSpawnManager.Pause();
        List<Ballon> ballons = _ballonsSpawnManager.BallonsPool.GetAllBallons();
        ballons.ForEach(ballon => ballon.Pause());
    }

    /// <summary>
    /// ����� � �����
    /// </summary>
    public void UnPause()
    {
        _ballonsSpawnManager.UnPause();
        List<Ballon> ballons = _ballonsSpawnManager.BallonsPool.GetAllBallons();
        ballons.ForEach(ballon => ballon.UnPause());
    }
}