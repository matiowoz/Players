using System.Collections.Generic;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        PlayerList playerList = new();

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Choose your Nickname: ");
            string nowyGracz = Console.ReadLine();
            Gracz gracz = new (nowyGracz);            
            playerList.PlayerAdd(gracz.Nick, gracz.Id);
            

        }
        Console.WriteLine();
        Console.WriteLine("Player List: ");
        Console.WriteLine();

        foreach (var pair in playerList.Players)
        {
            Console.WriteLine($"ID: {pair.Key} - {pair.Value}");
        }
    }
}

class Gracz
{
    readonly string nick;
    readonly int id;
    static int nextID = 0;

    public Gracz(string nowyGracz)
    {
        this.nick = nowyGracz;
        nextID++;
        id = nextID;
    }
    
    public Gracz()
        {
        this.nick = Nick;
        this.id = Id;
        }



    public string Nick
    {
        get
        {
            return this.nick;
        }
    }

    public int Id
    {
        get
        {
            return this.id;
        }
    }
}

class PlayerList
{
    private Dictionary<int, string> players;

    public Dictionary<int, string> Players
    {
        get
        {
            return players;
        }
    }

    public PlayerList()
    {
        players = [];
    }

    public void PlayerAdd(string nick, int id)
    {
        Players.Add(id, nick);
        
    }
}   
    
