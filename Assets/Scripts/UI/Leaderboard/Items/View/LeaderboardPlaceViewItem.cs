/// <summary>
/// ������������� ����� ������ � ������ ������� �������
/// </summary>
public class LeaderboardPlaceViewItem : AbstractLeaderboardViewItem
{
    protected override void OnLeaderboardModelChange(LeaderboardViewModel viewModel)
    {
        textMeshPro.text = viewModel.Place.ToString();
    }
}