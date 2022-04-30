using System.Collections;
using UnityEngine;

/// <summary>
/// Воздушный шарик
/// </summary>
[RequireComponent(typeof(Animator))]
public class Ballon : MonoBehaviour, IHittable
{
    private Animator _animator;
    private Coroutine deadReaction;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    /// <summary>
    /// Поставить на паузу
    /// </summary>
    public void Pause()
    {
        _animator.StartPlayback();
    }

    /// <summary>
    /// Снять с паузы
    /// </summary>
    public void UnPause()
    {
        _animator.StopPlayback();
    }

    
    public bool Hit()
    {
        if (deadReaction == null)
        {
            deadReaction = StartCoroutine(DeadReaction());
            return true;
        }
        return false;
    }

    private IEnumerator DeadReaction()
    {
        yield return null;
        gameObject.SetActive(false);
        deadReaction = null;
    }
}