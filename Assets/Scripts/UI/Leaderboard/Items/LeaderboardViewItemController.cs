using System;
using UnityEngine;

/// <summary>
/// ���������� ������ ������������� ������� �������
/// </summary>
public class LeaderboardViewItemController : MonoBehaviour
{
    public event Action<LeaderboardViewModel> OnLeaderboardModelChange = delegate { };

    private LeaderboardViewModel leaderboardViewModel;
    public LeaderboardViewModel LeaderboardViewModel
    {
        get
        {
            return leaderboardViewModel;
        }
        set
        {
            if (value != null || !value.Equals(leaderboardViewModel))
            {
                leaderboardViewModel = value;
                OnLeaderboardModelChange(leaderboardViewModel);
            }
        }
    }
}