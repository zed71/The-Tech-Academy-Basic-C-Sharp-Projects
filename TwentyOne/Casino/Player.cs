using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Player
    {
        //Constructor
        public Player(string name, int beginningBalance)
        {
            Hand = new List<Card>();
            Balance = beginningBalance;
            Name = Name;
        }
        private List<Card> _hand = new List<Card>();
        public List<Card> Hand { get { return _hand; } set { _hand = value; } }
        public int Balance { get; set; }
        public int Name { get; set; }
        public bool isActivelyPlaying { get; set; }
        public Guid Id { get; set; }
        public bool Stay { get; set; }


        public bool Bet (int amount)
        {
            if (Balance - amount < 0)
            {
                Console.WriteLine("You dont have enough to place a bet that size!");
                return false;
            }
            else
            {
                Balance -= amount;
                return true;
            }
        }


        // you can overload a +, -, *, / operaters using the method. The operators are specific to operator and to join 2 
        //objects together to add a player to the game.
        public static Game operator+ (Game game, Player player)
        {
            game.Players.Add(player);
            return game;
        }
        public static Game operator- (Game game, Player player)
        {
            game.Players.Remove(player);
            return game;
        }
    }
}
