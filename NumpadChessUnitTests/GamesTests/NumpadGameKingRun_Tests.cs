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
    public class NumpadGameKingRun_Tests
    {
        private int phoneNumberSize = 7;
        private ChessPieceType pieceType = ChessPieceType.King;

        [Test]
        public void DiscoveredNumbersStartingAt2()
        {
            // Arrange
            Coordinates2D startingPoint = new Coordinates2D(0, 1);
            var gameBoard = new NumpadBoard();
            gameBoard.board[startingPoint.Row, startingPoint.Col].SquareContent = new King(ChessPieceColor.White);
            var numpadGame = new NumpadChessGame(gameBoard);

            // Act
            var result = numpadGame.GetUniquePhoneNumbers(pieceType, startingPoint, phoneNumberSize);

            // Assert
            Assert.That(result.Count, Is.EqualTo(15265));
        }

        [Test]
        public void DiscoveredNumbersStartingAt3()
        {
            // Arrange
            Coordinates2D startingPoint = new Coordinates2D(0, 2);
            var gameBoard = new NumpadBoard();
            gameBoard.board[startingPoint.Row, startingPoint.Col].SquareContent = new King(ChessPieceColor.White);
            var numpadGame = new NumpadChessGame(gameBoard);

            // Act
            var result = numpadGame.GetUniquePhoneNumbers(pieceType, startingPoint, phoneNumberSize);

            // Assert
            Assert.That(result.Count, Is.EqualTo(10811));
        }

        [Test]
        public void DiscoveredNumbersStartingAt4()
        {
            // Arrange
            Coordinates2D startingPoint = new Coordinates2D(1, 0);
            var gameBoard = new NumpadBoard();
            gameBoard.board[startingPoint.Row, startingPoint.Col].SquareContent = new King(ChessPieceColor.White);
            var numpadGame = new NumpadChessGame(gameBoard);

            // Act
            var result = numpadGame.GetUniquePhoneNumbers(pieceType, startingPoint, phoneNumberSize);

            // Assert
            Assert.That(result.Count, Is.EqualTo(15984));
        }

        [Test]
        public void DiscoveredNumbersStartingAt5()
        {
            // Arrange
            Coordinates2D startingPoint = new Coordinates2D(1, 1);
            var gameBoard = new NumpadBoard();
            gameBoard.board[startingPoint.Row, startingPoint.Col].SquareContent = new King(ChessPieceColor.White);
            var numpadGame = new NumpadChessGame(gameBoard);

            // Act
            var result = numpadGame.GetUniquePhoneNumbers(pieceType, startingPoint, phoneNumberSize);

            // Assert
            Assert.That(result.Count, Is.EqualTo(22611));
        }

        [Test]
        public void DiscoveredNumbersStartingAt6()
        {
            // Arrange
            Coordinates2D startingPoint = new Coordinates2D(1, 2);
            var gameBoard = new NumpadBoard();
            gameBoard.board[startingPoint.Row, startingPoint.Col].SquareContent = new King(ChessPieceColor.White);
            var numpadGame = new NumpadChessGame(gameBoard);

            // Act
            var result = numpadGame.GetUniquePhoneNumbers(pieceType, startingPoint, phoneNumberSize);

            // Assert
            Assert.That(result.Count, Is.EqualTo(15984));
        }

        [Test]
        public void DiscoveredNumbersStartingAt7()
        {
            // Arrange
            Coordinates2D startingPoint = new Coordinates2D(2, 0);
            var gameBoard = new NumpadBoard();
            gameBoard.board[startingPoint.Row, startingPoint.Col].SquareContent = new King(ChessPieceColor.White);
            var numpadGame = new NumpadChessGame(gameBoard);

            // Act
            var result = numpadGame.GetUniquePhoneNumbers(pieceType, startingPoint, phoneNumberSize);

            // Assert
            Assert.That(result.Count, Is.EqualTo(13138));
        }

        [Test]
        public void DiscoveredNumbersStartingAt8()
        {
            // Arrange
            Coordinates2D startingPoint = new Coordinates2D(2, 1);
            var gameBoard = new NumpadBoard();
            gameBoard.board[startingPoint.Row, startingPoint.Col].SquareContent = new King(ChessPieceColor.White);
            var numpadGame = new NumpadChessGame(gameBoard);

            // Act
            var result = numpadGame.GetUniquePhoneNumbers(pieceType, startingPoint, phoneNumberSize);

            // Assert
            Assert.That(result.Count, Is.EqualTo(17977));
        }

        [Test]
        public void DiscoveredNumbersStartingAt9()
        {
            // Arrange
            Coordinates2D startingPoint = new Coordinates2D(2, 2);
            var gameBoard = new NumpadBoard();
            gameBoard.board[startingPoint.Row, startingPoint.Col].SquareContent = new King(ChessPieceColor.White);
            var numpadGame = new NumpadChessGame(gameBoard);

            // Act
            var result = numpadGame.GetUniquePhoneNumbers(pieceType, startingPoint, phoneNumberSize);

            // Assert
            Assert.That(result.Count, Is.EqualTo(13138));
        }
    }
}
