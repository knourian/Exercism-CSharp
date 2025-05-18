public static class Tournament
{
    private const string Header = "Team                           | MP |  W |  D |  L |  P";
    private const string NewLine = "\n";
    public static void Tally(Stream inStream, Stream outStream)
    {
        using var reader = new StreamReader(inStream);
        using var writer = new StreamWriter(outStream);
        writer.NewLine = NewLine;
        var teams = new Dictionary<string, Team>();

        var line = string.Empty;
        while ((line = reader.ReadLine()) != null)
        {
            var parts = line.Split(';');
            if (parts.Length != 3) continue;

            var team1 = parts[0];
            var team2 = parts[1];
            var result = parts[2];

            if (!teams.ContainsKey(team1))
                teams[team1] = new Team(team1);
            if (!teams.ContainsKey(team2))
                teams[team2] = new Team(team2);

            teams[team1].AddMatch(result == "win" ? 3 : result == "loss" ? 0 : 1);
            teams[team2].AddMatch(result == "loss" ? 3 : result == "win" ? 0 : 1);
        }

        writer.Write(Header);
        if (teams.Count != 0)
        {
            writer.Write(NewLine);
        }
        var teamsOrdered = teams.Values.OrderByDescending(t => t.Points).ThenBy(t => t.Name);
        for (int i = 0; i < teamsOrdered.Count(); i++)
        {
            var team = teamsOrdered.ElementAt(i);
            if (i == teamsOrdered.Count() - 1)

            {
                writer.Write(team.ToString());
            }
            else
            {
                writer.WriteLine(team.ToString());
            }
        }
    }


    internal class Team
    {
        public string Name { get; }
        public int MatchesPlayed { get; private set; }
        public int Wins { get; private set; }
        public int Draws { get; private set; }
        public int Losses { get; private set; }
        public int Points => Wins * 3 + Draws;

        public Team(string name)
        {
            Name = name;
        }

        public void AddMatch(int result)
        {
            MatchesPlayed++;
            if (result == 3) Wins++;
            else if (result == 1) Draws++;
            else Losses++;
        }

        public override string ToString()
        {
            return $"{Name,-30} | {MatchesPlayed,2} | {Wins,2} | {Draws,2} | {Losses,2} | {Points,2}";
        }
    }
}
