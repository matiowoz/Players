using System.Collections.Generic;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Choose your Nickname: ");
            string nowyGracz = Console.ReadLine();
            Gracz gracz = new Gracz(nowyGracz);
            PlayerList gracz = new PlayerList(nowyGracz);
            PlayerList.PlayerAdd(gracz.Id, gracz.Nick);
            Console.WriteLine("");

        }
        Console.WriteLine("Player List: ");

        foreach (var pair in Players)
        {
            Console.WriteLine($"ID: {pair.Key} - {pair.Value}");
        }
    }
}

class Gracz
{

    public Gracz(string nowyGracz)
    {
        this.nick = nowyGracz;
        nextID++;
        id = nextID;
    }
    string nick;
    int id;
    static int nextID = 0;

    public Gracz(string nick, int id)
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
    private Gracz NickToList;
    private Gracz IdToList;
    

    Dictionary<int, string> Players = new Dictionary<int, string>();

    string Nickname;
    int ID;

    public PlayerAdd(string NickToList, int IdToList)
    {
        this.Nickname = NickToList;
        this.ID = IdToList;
        

        Players.Add(ID, Nickname);
    }
    
}