using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Пулл воздушных шаров
/// </summary>
public class BallonsPool
{
    private Dictionary<int, List<Ballon>> _ballonsByIndex = new Dictionary<int, List<Ballon>>();
    private IReadOnlyList<Ballon> _ballonsPrefabs;
    private Transform _parentTransform;

    public BallonsPool(IReadOnlyList<Ballon> ballonsPrefabs, Transform parentTransform)
    {
        _ballonsPrefabs = ballonsPrefabs;
        _parentTransform = parentTransform;
        for (int i = 0; i < _ballonsPrefabs.Count; i++)
        {
            _ballonsByIndex.Add(i, new List<Ballon>());
        }
    }

    /// <summary>
    /// Получить воздушный шарик из пула
    /// </summary>
    public Ballon GetBallon(int index)
    {
        List<Ballon> ballons = _ballonsByIndex[index];
        for (int i = 0; i < ballons.Count; i++)
        {
            if (!ballons[i].gameObject.activeInHierarchy)
            {
                return ballons[i];
            }
        }

        var ballon = GameObject.Instantiate(_ballonsPrefabs[index], _parentTransform);
        ballons.Add(ballon);

        return ballon;
    }

    /// <summary>
    /// Получить все воздушные шарики из пула
    /// </summary>
    public List<Ballon> GetAllBallons()
    {
        var ballons = new List<Ballon>();
        foreach (var entry in _ballonsByIndex)
        {
            foreach (var ballon in entry.Value)
            {
                ballons.Add(ballon);
            }
        }
        return ballons;
    }
}