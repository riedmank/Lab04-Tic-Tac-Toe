using System;
using Xunit;
using static Lab04_TicTacToe.Program;
using Lab04_TicTacToe.Classes;

namespace TicTacToeTest
{
    public class UnitTest1
    {
        [Fact]
        public void CheckForHorizontalWin()
        {
            Player p1 = new Player("test 1", "X");
            Player p2 = new Player("test 2", "O");
            Game Game = new Game(p1, p2);
            Assert.True(Game.CheckForWinner(Game.Board));
        }

        [Fact]
        public void CheckForVerticalWin()
        {
            Player p1 = new Player("test 1", "X");
            Player p2 = new Player("test 2", "O");
            Game Game = new Game(p1, p2);
            Assert.True(Game.CheckForWinner(Game.Board));
        }

        [Fact]
        public void CheckForDiagonalWin()
        {
            Player p1 = new Player("test 1", "X");
            Player p2 = new Player("test 2", "O");
            Game Game = new Game(p1, p2);
            Assert.True(Game.CheckForWinner(Game.Board));
        }

        [Fact]
        public void CheckTurnSwitch()
        {
            Player p1 = new Player("test 1", "X");
            Player p2 = new Player("test 2", "O");
            Game Game = new Game(p1, p2);
            p1.IsTurn = true;
            Game.SwitchPlayer();
            Assert.True(p2.IsTurn);
        }
    }
}
