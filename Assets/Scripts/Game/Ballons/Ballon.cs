using System.Collections;
using UnityEngine;

/// <summary>
/// ��������� �����
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
    /// ��������� �� �����
    /// </summary>
    public void Pause()
    {
        _animator.StartPlayback();
    }

    /// <summary>
    /// ����� � �����
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