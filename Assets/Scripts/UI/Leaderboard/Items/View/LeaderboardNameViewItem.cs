/// <summary>
/// ������������� ����� ������ � ������ ������� �������
/// </summary>
public class LeaderboardNameViewItem : AbstractLeaderboardViewItem
{
    protected override void OnLeaderboardModelChange(LeaderboardViewModel viewModel)
    {
        textMeshPro.text = viewModel.Name;
    }
}