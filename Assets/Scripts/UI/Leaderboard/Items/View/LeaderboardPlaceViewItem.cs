/// <summary>
/// Представление места игрока в модели таблицы лидеров
/// </summary>
public class LeaderboardPlaceViewItem : AbstractLeaderboardViewItem
{
    protected override void OnLeaderboardModelChange(LeaderboardViewModel viewModel)
    {
        textMeshPro.text = viewModel.Place.ToString();
    }
}