using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.XPath;

class Program
{
    static void Main(string[] args)
    {
        PlayerList playerList = new();

        while (true)
        {
            

            Menu.ShowMenu();
            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1": // Add player
                    Console.WriteLine("Choose your Nickname: ");
                    string nowyGracz = Console.ReadLine();
                    Gracz gracz = new(nowyGracz);
                    playerList.PlayerAdd(gracz.Nick, gracz.Id, gracz.Experience, gracz.Money);
                    Console.WriteLine($"ID: {gracz.Id} - {gracz.Nick}");
                    break;

                case "2": // Player List              
                    foreach (var pair in playerList.Players)
                    {
                        Console.WriteLine($"ID: {pair.Key} - {pair.Value}");
                    }
                    break;
            }



        if (choice == "0")
                break;
        }
    }

    class Gracz
    {
        readonly string nick;
        readonly int id;
        static int nextID = 0;
        int experience;
        float money;

        public Gracz(string nowyGracz)
        {
            this.nick = nowyGracz;
            nextID++;
            id = nextID;
            experience = 1;
            money = 0;
        }

        public Gracz(string nowyGracz, int xp, float gold)
        {
            this.nick = nowyGracz;
            nextID++;
            id = nextID;
            experience = xp;
            money = gold;
        }

        public Gracz()
        {
            this.nick = Nick;
            this.id = Id;
        }


        public string Nick
        {
            get { return this.nick; }
        }

        public int Id
        {
            get { return this.id; }
        }

        public int Experience
        {
            get {return experience;}
            set { experience = value;}  
        }

        public float Money 
        { 
            get { return money;}
            set { money = value;}
        }


    }

    class PlayerList
    {
        private readonly Dictionary<int, Gracz> players = [];

        public Dictionary<int, Gracz> Players
        {
            get
            {
                return players;
            }
        }


        public void PlayerAdd(string nick, int id,int experience, float money)
        {
             Players.Add(id, new Gracz {nick, experience, money}); // nie dziala :(
        }
    }

    class Menu
    {
        static public void ShowMenu()
        {
            Console.WriteLine("Menu: ");
            Console.WriteLine();
            Console.WriteLine("1. Add Player");
            Console.WriteLine("2. Player List");            
            Console.WriteLine("0. Quit");
        }
    }
}