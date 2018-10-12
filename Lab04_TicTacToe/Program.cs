using System;
using Lab04_TicTacToe.Classes;

namespace Lab04_TicTacToe
{
	public class Program
	{
		public static void Main(string[] args)
		{
            PlayGame();
		}

		public static void PlayGame()
		{
            Console.WriteLine("Welcome to Tic Tac Toe.");
            Console.WriteLine("Who is player one?");
            Player p1 = new Player(Console.ReadLine(), "X");
            Console.WriteLine("Who is player two?");
            Player p2 = new Player(Console.ReadLine(), "O");
            Console.WriteLine("Let's play the game!!");
            Game Game = new Game(p1, p2);
            Player Winner = Game.Play();
            if (Winner == null)
            {
                Console.WriteLine("Tie game.");
            }
            else
            {
                Console.WriteLine($"Winner is: {Winner.Name}");
            }
        }
	}
}
