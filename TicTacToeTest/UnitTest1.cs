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
            Board Board = new Board();
            Board.GameBoard = new string[,]
            {
                {"X","X","X" },
                {"4", "5", "6" },
                {"7", "8", "9" }
            };
            Game.Board = Board;
            Assert.True(Game.CheckForWinner(Game.Board));
        }

        [Fact]
        public void CheckForVerticalWin()
        {
            Player p1 = new Player("test 1", "X");
            Player p2 = new Player("test 2", "O");
            Game Game = new Game(p1, p2);
            Board Board = new Board();
            Board.GameBoard = new string[,]
            {
                {"X","2","3" },
                {"X", "5", "6" },
                {"X", "8", "9" }
            };
            Game.Board = Board;
            Assert.True(Game.CheckForWinner(Game.Board));
        }

        [Fact]
        public void CheckForDiagonalWin()
        {
            Player p1 = new Player("test 1", "X");
            Player p2 = new Player("test 2", "O");
            Game Game = new Game(p1, p2);
            Board Board = new Board();
            Board.GameBoard = new string[,]
            {
                {"X","2","3" },
                {"4", "X", "6" },
                {"7", "8", "X" }
            };
            Game.Board = Board;
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
            Assert.False(p1.IsTurn);
        }

        [Fact]
        public void UserInputCorrelatesToCorrectBoardSpaceRow()
        {
            Player p1 = new Player("test 1", "X");
            Player p2 = new Player("test 2", "O");
            Game Game = new Game(p1, p2);
            Position position = new Position(1, 1);
            Position position1 = Player.PositionForNumber(5);
            Assert.Equal(position.Row, position1.Row);
        }

        [Fact]
        public void UserInputCorrelatesToCorrectBoardSpaceColumn()
        {
            Player p1 = new Player("test 1", "X");
            Player p2 = new Player("test 2", "O");
            Game Game = new Game(p1, p2);
            Position position = new Position(1, 1);
            Position position1 = Player.PositionForNumber(5);
            Assert.Equal(position.Column, position1.Column);
        }

        [Fact]
        public void TieGameTest()
        {
            Player p1 = new Player("test 1", "X");
            Player p2 = new Player("test 2", "O");
            Game Game = new Game(p1, p2);
            Board Board = new Board();
            Board.GameBoard = new string[,]
            {
                {"X","O","X" },
                {"O", "X", "X" },
                {"O", "X", "O" }
            };
            Game.Board = Board;
            Game.CheckForWinner(Game.Board);
            Assert.Null(Game.Winner);
        }
    }
}
