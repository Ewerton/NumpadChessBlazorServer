using ChessLib;
using ChessLib.Boards.Numpad;
using ChessLib.Games;
using ChessLib.Pieces.Chess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumpadChessUnitTests.GamesTests
{
    public class NumpadGameInitialization_Tests
    {
        [Test]
        public void NoPieceTheBoard_Test()
        {
            // Arrange
            var gameBoard = new NumpadBoard();

            var phoneNumberSize = 7;

            // Act
            var ex = Assert.Throws<Exception>(() => new NumpadChessGame(gameBoard));

            // Assert
            Assert.That(ex.Message, Is.EqualTo("No piece on the board. Please put a piece on the board first."));
        }

        //
        [Test]
        public void StartingOutsideTheBoard_Test()
        {
            // Arrange
            Coordinates2D startingPoint = new Coordinates2D(-1, 0);
            var gameBoard = new NumpadBoard();
            gameBoard.board[0, 0].SquareContent = new Knight(ChessPieceColor.White);
            var numpadGame = new NumpadChessGame(gameBoard);
            var phoneNumberSize = 7;

            // Act
            var ex = Assert.Throws<ArgumentException>(() => numpadGame.GetUniquePhoneNumbers(ChessPieceType.Knight, startingPoint, phoneNumberSize));

            // Assert
            Assert.That(ex.Message, Is.EqualTo("Starting point is outside the board."));

        }

        [Test]
        public void StartingAtNumberOne_Test()
        {
            // Arrange
            Coordinates2D startingPoint = new Coordinates2D(0, 0);
            var gameBoard = new NumpadBoard();
            gameBoard.board[startingPoint.Row, startingPoint.Col].SquareContent = new Knight(ChessPieceColor.White);
            var numpadGame = new NumpadChessGame(gameBoard);
            var phoneNumberSize = 7;

            // Act
            var ex = Assert.Throws<Exception>(() => numpadGame.GetUniquePhoneNumbers(ChessPieceType.Knight, startingPoint, phoneNumberSize));

            // Assert
            Assert.That(ex.Message, Is.EqualTo("Phone number cannot start with zero or one."));
        }

        [Test]
        public void StartingAtNumberZero_Test()
        {
            // Arrange
            Coordinates2D startingPoint = new Coordinates2D(3, 1);
            var gameBoard = new NumpadBoard();
            gameBoard.board[startingPoint.Row, startingPoint.Col].SquareContent = new Knight(ChessPieceColor.White);
            var numpadGame = new NumpadChessGame(gameBoard);
            var phoneNumberSize = 7;

            // Act
            var ex = Assert.Throws<Exception>(() => numpadGame.GetUniquePhoneNumbers(ChessPieceType.Knight, startingPoint, phoneNumberSize));

            // Assert
            Assert.That(ex.Message, Is.EqualTo("Phone number cannot start with zero or one."));
        }

        [Test]
        public void PhoneSizeNumberMustBeGreaterThanZero_Test()
        {
            // Arrange
            Coordinates2D startingPoint = new Coordinates2D(0, 1);
            var gameBoard = new NumpadBoard();
            gameBoard.board[startingPoint.Row, startingPoint.Col].SquareContent = new Knight(ChessPieceColor.White); // putting a piece on the number "2" 
            var numpadGame = new NumpadChessGame(gameBoard);
            var phoneNumberSize = 0;

            // Act
            var ex = Assert.Throws<ArgumentException>(() => numpadGame.GetUniquePhoneNumbers(ChessPieceType.Knight, startingPoint, phoneNumberSize));

            // Assert
            Assert.That(ex.Message, Is.EqualTo("Phone number size must be greater than zero."));
        }
    }
}
