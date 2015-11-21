using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class LeagueManager
{

    public static void HandleInput(string input)
    {
        var inputArgs = input.Split();
        switch (inputArgs[0])
        {
            case "AddTeam":
                AddTeam(inputArgs[1], inputArgs[2], DateTime.Parse(inputArgs[3]));
                break;

            case "AddMatch":

                Team home = League.Teams.First(team => team.Name.Equals(inputArgs[2]));
                Team away = League.Teams.First(team => team.Name.Equals(inputArgs[3]));
                AddMatch(int.Parse(inputArgs[1]), home, away, int.Parse(inputArgs[4]), int.Parse(inputArgs[5]));
                break;

            case "AddPlayerToTeam":
                AddPlayerToTeam(inputArgs[1], inputArgs[2], DateTime.Parse(inputArgs[3]), Decimal.Parse(inputArgs[4]),inputArgs[5]);
                break;

            case "ListTeams":
                Console.WriteLine(ListTeams());
                break;
            case "ListMatches":
                Console.WriteLine(ListMatches());
                break;
            default:
                break;
        }
    }

    private static void AddTeam(string name, string nickname, DateTime dateFounded)
    {
        Team teamToAdd = new Team(name, nickname, dateFounded);
        League.AddTeam(teamToAdd);
    }

    private static void AddMatch(int id, Team homeTeam, Team awayTeam, int homeTeamGoals, int awayTeamGoals)
    {
        Match matchToAdd = new Match(homeTeam, awayTeam, id,homeTeamGoals,awayTeamGoals);
        League.AddMatch(matchToAdd);
    }

    private static void AddPlayerToTeam(string firstName, string lastName, DateTime dateOfBirth, decimal salary, string teamName)
    {
        List<Team> teams = League.Teams;
        Team team = teams[0] ;
        for (int i = 0; i < League.Teams.Count(); i++)
        {
            if (teams[i].Name == teamName)
            {
                team = teams[i];
            }
        }
        Player playerToAdd = new Player(firstName, lastName, dateOfBirth, salary, team);
        team.AddPlayer(playerToAdd);
    }

    private static string ListTeams()
    {
        StringBuilder builder = new StringBuilder();
        builder.Append("\nList Of Teams\n--------------\n");
        foreach (var item in League.Teams)
        {
            builder.Append(item.Name.PadLeft(20,' ') + "\n");
        }
        return builder.ToString();
    }

    private static string ListMatches()
    {
        StringBuilder builder = new StringBuilder();
        builder.Append("\nList Of Matches\n--------------\n");
        foreach (var item in League.Matches)
        {
            builder.Append(string.Format("{0} VS {1}\n",item.HomeTeam.Name, item.AwayTeam.Name));
        }
        return builder.ToString();
    }
}