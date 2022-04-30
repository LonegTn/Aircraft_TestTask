using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Настройки создания воздушных шариков
/// </summary>
[CreateAssetMenu(fileName = "new BallonsSpawnSettings",
    menuName = "Player/Settings/BallonsSpawnSettings", order = 0)]
public class BallonsSpawnSettings : ScriptableObject
{
    [Header("Spawn speed per seconds")]
    [SerializeField] private float _startSpawnSpeed;
    public float StartSpawnSpeed => _startSpawnSpeed;

    [SerializeField] private float _endSpawnSpeed;
    public float EndSpawnSpeed => _endSpawnSpeed;

    [Header("In seconds")]
    [SerializeField] private float _spawnSpeedIncrease;
    public float SpawnSpeedIncrease => _spawnSpeedIncrease;

    [SerializeField] private float _speedIncreaseFrequency;
    public float SpeedIncreaseFrequency => _speedIncreaseFrequency;

    [Header("Spawn prefabs")]
    [SerializeField] private Ballon[] _ballonsPrefabs;
    public IReadOnlyList<Ballon> BallonsPrefabs => _ballonsPrefabs;
}