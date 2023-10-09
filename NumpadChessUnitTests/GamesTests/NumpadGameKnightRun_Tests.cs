using ChessLib;
using ChessLib.Boards.Numpad;
using ChessLib.Games;
using ChessLib.Pieces.Chess;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumpadChessUnitTests.GamesTests
{
    public class NumpadGameKnightRun_Tests
    {
        private int phoneNumberSize = 7;

        [Test]
        public void DiscoveredNumbersForKnightStartingAtNumber2()
        {
            // Arrange
            Coordinates2D startingPoint = new Coordinates2D(0, 1);
            var gameBoard = new NumpadBoard();
            gameBoard.board[startingPoint.Row, startingPoint.Col].SquareContent = new Knight(ChessPieceColor.White);
            var numpadGame = new NumpadChessGame(gameBoard);

            // Act
            var result = numpadGame.GetUniquePhoneNumbers(ChessPieceType.Knight, startingPoint, phoneNumberSize);

            // Assert
            Assert.That(result.Count, Is.EqualTo(104));
        }

       
    }
}
