/// <summary>
/// ������������� ����������� ��������� ����� � ������ ������� �������
/// </summary>
public class LeaderboardScoreViewItem : AbstractLeaderboardViewItem
{
    protected override void OnLeaderboardModelChange(LeaderboardViewModel viewModel)
    {
        textMeshPro.text = viewModel.Score.ToString();
    }
}