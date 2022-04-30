/// <summary>
/// Представление колличества набранных очков в модели таблицы лидеров
/// </summary>
public class LeaderboardScoreViewItem : AbstractLeaderboardViewItem
{
    protected override void OnLeaderboardModelChange(LeaderboardViewModel viewModel)
    {
        textMeshPro.text = viewModel.Score.ToString();
    }
}