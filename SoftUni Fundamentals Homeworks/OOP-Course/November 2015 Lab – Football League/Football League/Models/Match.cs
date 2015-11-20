using System;

public class Match
{
    private Team homeTeam;
    private Team awayTeam;
    private Score score;
    private int id;

    public Match(Team home, Team away,int id,int homeTeamGoals, int awayTeamGoals)
    {
        this.homeTeam = home;
        this.awayTeam = away;
        this.score = new Score(homeTeamGoals,awayTeamGoals);
        this.id = id;
    }

    public Team HomeTeam
    {
        get { return this.homeTeam; }
        set { this.homeTeam = value; }
    }

    public Team AwayTeam
    {
        get { return this.awayTeam; }
        set { this.awayTeam = value; }
    }

    public Team GetWinner()
    {
        if (isDraw())
        {
            return null;
        }

        return this.score.HomeTeamGoals > this.score.AwayTeamGoals 
            ? this.HomeTeam 
            : this.AwayTeam;
    }

    public int ID
    {
        get { return this.id; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("ID cannot be negative");
            }
            this.id = value;
        }
    }

    private bool isDraw()
    {
        return this.score.HomeTeamGoals == this.score.AwayTeamGoals;
    }
}