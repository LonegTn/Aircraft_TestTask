using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Контроллер игрока
/// </summary>
public class PlayerController : MonoBehaviour
{
    [SerializeField] private AbstractInputManager _inputManager;
    [SerializeField] private ScoreManager _scoreManager;
    [SerializeField] private UIController _uIController;
    [SerializeField] private BallonsController _ballonsController;

    /// <summary>
    /// Поставить на паузу
    /// </summary>
    public void Pause()
    {
        _ballonsController.Pause();
        _uIController.ShowPausePanel();
        _inputManager.GainControl();
    }

    /// <summary>
    /// Снять с паузы
    /// </summary>
    public void UnPause()
    {
        _ballonsController.UnPause();
        _uIController.HidePausePanel();
        _inputManager.ReleaseControl();
    }

    private void OnEnable()
    {
        _inputManager.OnClick += OnClick;
    }

    private void OnDisable()
    {
        _inputManager.OnClick -= OnClick;
        SaveResult();
    }

    private void SaveResult()
    {
        List<LeaderboardModel> models =
            SaveController.Load<LeaderboardModel>(TagHolder.LEADER_BOARD_PREFS_KEY);

        var model = new LeaderboardModel(
            PlayerInfo.PlayerInfoModel?.Name ?? "defaultName",
            _scoreManager.Score);

        models.Add(model);
        SaveController.Save<LeaderboardModel>(TagHolder.LEADER_BOARD_PREFS_KEY, models);
    }

    private void OnClick(Vector3 mousePos)
    {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(mousePos), Vector2.zero);

        if (hit.collider != null)
        {
            Component hittableComponent = hit.collider.GetComponent(typeof(IHittable));
            IHittable hittableObject = hittableComponent != null ? (IHittable)hittableComponent : null;

            if (hittableObject != null)
            {
                if (hittableObject.Hit())
                {
                    _scoreManager.AddScore(1);
                }
            }
        }

    }
}