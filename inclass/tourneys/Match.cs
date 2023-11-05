public class Match
{
    private Team _team1;
    private Team _team2;
    public Match(Team team1, Team team2)
    {
        _team1 = team1;
        _team2 = team2;
    }
    public void DecideWin()
    {
        System.Console.WriteLine("Which Team Won?");
        System.Console.WriteLine($"1 {_team1.GetTeamName()}");
        System.Console.WriteLine($"2 {_team2.GetTeamName()}");
        string winner = Console.ReadLine();
        if(winner == "1")
        {
            _team1.Addwin();
            _team2.AddLosses();
        }
        else{
            _team1.AddLosses();
            _team2.Addwin();
        }
    }
}