using System.Collections.Generic;
using System.Linq;
using UnityEngine;

/// <summary>
/// Контроллер таблицы лидеров
/// </summary>
public class LeaderboardController : MonoBehaviour
{
    [SerializeField] private LeaderboardViewItemController leaderboardViewPrefab;
    [SerializeField] private Transform content;

    private List<LeaderboardViewModel> _viewModels = new List<LeaderboardViewModel>();

    private void Awake()
    {
        InitViewModels();
        InitView();
    }

    private void InitView()
    {
        foreach (var item in _viewModels)
        {
            LeaderboardViewItemController viewItemController =
                Instantiate(leaderboardViewPrefab, content);

            viewItemController.LeaderboardViewModel = item;
        }
    }

    private void InitViewModels()
    {
        List<LeaderboardModel> models =
            SaveController.Load<LeaderboardModel>(TagHolder.LEADER_BOARD_PREFS_KEY);

        models = models.OrderByDescending(x => x.Score).ToList();

        for (int i = 0; i < models.Count; i++)
        {
            _viewModels.Add(
                new LeaderboardViewModel(
                    i + 1, 
                    models[i].Name, 
                    models[i].Score));
        }
    }
}