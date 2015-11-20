using System;
using System.Collections.Generic;
using System.Linq;

public static class League
{
    private static List<Team> teams = new List<Team>();
    private static List<Match> matches = new List<Match>();

    public static List<Team> Teams
    {
        get { return teams; }
    }
    public static List<Match> Matches
    {
        get { return matches; }
    }

    public static void AddTeam(Team team)
    {
        if (teams.Any(t => t.Name == team.Name))
        {
            throw new InvalidOperationException("Team already exists");
        }
        teams.Add(team);
    }

    public static void AddMatch(Match match)
    {
        if (matches.Any(m => m.ID == match.ID))
        {
            throw new InvalidOperationException("Match already exist for that league");
        }
    }
}