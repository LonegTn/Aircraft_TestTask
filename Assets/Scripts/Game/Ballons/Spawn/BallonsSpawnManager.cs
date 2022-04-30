using System.Collections;
using UnityEngine;

/// <summary>
/// Создание воздушных шариков
/// </summary>
public class BallonsSpawnManager : MonoBehaviour
{
    private BallonsPool _ballonsPool;
    public BallonsPool BallonsPool => _ballonsPool;

    [SerializeField] private BallonsSpawnSettings settings;
    [SerializeField] private Transform container;

    private Bounds _bounds;
    private float _spawnSpeed;
    private bool _isPaused;

    /// <summary>
    /// Поставить на паузу
    /// </summary>
    public void Pause()
    {
        _isPaused = true;
    }

    /// <summary>
    /// Снять с паузы
    /// </summary>
    public void UnPause()
    {
        _isPaused = false;
    }

    private void Awake()
    {
        _bounds = new Bounds(Vector3.zero, new Vector3(Screen.width, Screen.height, 0));
        _spawnSpeed = settings.StartSpawnSpeed;
        _ballonsPool = new BallonsPool(settings.BallonsPrefabs, container);
        StartCoroutine(Spawn());
        StartCoroutine(IncreaseSpawnSpeed());
    }

    private IEnumerator IncreaseSpawnSpeed()
    {
        while(_spawnSpeed < settings.EndSpawnSpeed)
        {
            yield return new WaitForSeconds(settings.SpeedIncreaseFrequency);

            while(_isPaused)
            {
                yield return null;
            }

            _spawnSpeed += settings.SpawnSpeedIncrease;
        }
    }

    private IEnumerator Spawn()
    {
        while(enabled)
        {
            while (_isPaused)
            {
                yield return null;
            }

            int prefabIndex = Random.Range(0, settings.BallonsPrefabs.Count - 1);
            var ballon = _ballonsPool.GetBallon(prefabIndex);

            float xPos = Random.Range(_bounds.min.x, _bounds.max.x);
            ballon.gameObject.SetActive(true);
            ballon.transform.localPosition = new Vector3(xPos, 0, -1);

            yield return new WaitForSeconds(1 / _spawnSpeed);
        }
    }
}