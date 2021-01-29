using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    //the Game class is a abstract class, they are a way to keep control and design of program
    public abstract class Game
    {
        private List<Player> _players = new List<Player>();
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();
        public List<Player> Players { get { return _players; } set { _players = value; } }

        public string Name { get; set; }
        //the dictionary object to track bets
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } }
        //all a abstract method does it ensure that class inheriting must follow the method
        public abstract void Play();

        // method to call list of players, playing the current game, the virtual method in a abstract class means that the method gets inherited
        //but it has the ability to override it. 
        public virtual void ListPlayers()
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name);
            }

        }
    }
}
