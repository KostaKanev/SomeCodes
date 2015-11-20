using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Team
{
    private string name;
    private string nickname;
    private DateTime dateFounded;
    private List<Player> players;
    
    public Team(string name, string nickname, DateTime dateFounded)
    {
        this.Name = name;
        this.Nickname = nickname;
        this.DateFounded = dateFounded;
        this.players = new List<Player>();
    }

    public string Name
    {
        get { return this.name; }
        set
        {
            if (value.Length < 5)
            {
                throw new ArgumentException("The name must be least 5 characters");
            }
            else
            {
                this.name = value;
            }
        }
    }

    public string Nickname
    {
        get { return this.nickname; }
        set
        {
            if (value.Length < 5)
            {
                throw new ArgumentException("The nickname must be least 5 characters");
            }
            else
            {
                this.nickname = value;
            }
        }
    }

    public DateTime DateFounded
    {
        get { return this.dateFounded; }
        set
        {
            if (value.Year < 1850)
            {
                throw new ArgumentException("The DateFounded’s year should be after 1850");
            }
            this.dateFounded = value;
        }
    }

    public List<Player> Players
    {
        get { return this.players; }
    }

    public object StingBuilder { get; private set; }

    public void AddPlayer(Player player)
    {
        if (CheckIfPlayerExists(player))
        {
            throw new InvalidOperationException("Player already exists for that team");
        }
        this.players.Add(player);
    }

    public bool CheckIfPlayerExists(Player player)
    {
        return this.players.Any(p => p.FirstName == player.FirstName && p.LastName == player.LastName);
    }
}