public class Team 

{
    private string _name;
    private List<Player> _roster = new List<Player>();
    private int _wins = 0;
    private int _losses = 0;
    public Team(string name)
    {
        _name = name;

    }
    public void AddPlayer(Player p)
    {
        _roster.Add(p);
    }
    public void AddWin()
    {
        _wins++;
    }
    public void AddLosses()
    {
        _losses++;
    }
    public void DisplayRoster()
    {
        System.Console.WriteLine();
        System.Console.WriteLine(_name);
        System.Console.WriteLine($"Wins: {_wins} Losses: {_losses}");
        System.Console.WriteLine("---------------------------------");
        foreach (Player p in _roster)
        {
            p.Display();
        }
        System.Console.WriteLine();
    }

    public string GetTeamName()
    {
        return _name;
    }
}