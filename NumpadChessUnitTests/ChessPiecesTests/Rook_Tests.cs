using ChessLib.Pieces.Chess;
using ChessLib;

namespace NumpadChessUnitTests.ChessPiecesTests
{
    public class Rook_Tests
    {
        [Test]
        public void GetPossibleMoves()
        {
            // Arrange
            var rook = new Rook(ChessPieceColor.White);

            // Act
            var possibleMoves = rook.GetPossibleMoves();

            // Assert
            Assert.That(possibleMoves.Count(), Is.EqualTo(28));
            Assert.That(possibleMoves.Contains(new Coordinates2D(0, 1))); // One column right
            Assert.That(possibleMoves.Contains(new Coordinates2D(0, 2))); // Two columns right
            Assert.That(possibleMoves.Contains(new Coordinates2D(0, 3))); // Three columns right
            Assert.That(possibleMoves.Contains(new Coordinates2D(0, 4))); // Four columns right
            Assert.That(possibleMoves.Contains(new Coordinates2D(0, 5))); // Five columns right
            Assert.That(possibleMoves.Contains(new Coordinates2D(0, 6))); // Six columns right
            Assert.That(possibleMoves.Contains(new Coordinates2D(0, 7))); // Seven columns right

            //To the left
            Assert.That(possibleMoves.Contains(new Coordinates2D(0, -1))); // One column left
            Assert.That(possibleMoves.Contains(new Coordinates2D(0, -2))); // Two columns left
            Assert.That(possibleMoves.Contains(new Coordinates2D(0, -3))); // Three columns left
            Assert.That(possibleMoves.Contains(new Coordinates2D(0, -4))); // Four columns left
            Assert.That(possibleMoves.Contains(new Coordinates2D(0, -5))); // Five columns left
            Assert.That(possibleMoves.Contains(new Coordinates2D(0, -6))); // Six columns left
            Assert.That(possibleMoves.Contains(new Coordinates2D(0, -7))); // Seven columns left

            // Up
            Assert.That(possibleMoves.Contains(new Coordinates2D(1, 0))); // One row up
            Assert.That(possibleMoves.Contains(new Coordinates2D(2, 0))); // Two rows up
            Assert.That(possibleMoves.Contains(new Coordinates2D(3, 0))); // Three rows up
            Assert.That(possibleMoves.Contains(new Coordinates2D(4, 0))); // Four rows up
            Assert.That(possibleMoves.Contains(new Coordinates2D(5, 0))); // Five rows up
            Assert.That(possibleMoves.Contains(new Coordinates2D(6, 0))); // Six rows up
            Assert.That(possibleMoves.Contains(new Coordinates2D(7, 0))); // Seven rows up

            // Down
            Assert.That(possibleMoves.Contains(new Coordinates2D(-1, 0))); // One row down
            Assert.That(possibleMoves.Contains(new Coordinates2D(-2, 0))); // Two rows down
            Assert.That(possibleMoves.Contains(new Coordinates2D(-3, 0))); // Three rows down
            Assert.That(possibleMoves.Contains(new Coordinates2D(-4, 0))); // Four rows down
            Assert.That(possibleMoves.Contains(new Coordinates2D(-5, 0))); // Five rows down
            Assert.That(possibleMoves.Contains(new Coordinates2D(-6, 0))); // Six rows down
            Assert.That(possibleMoves.Contains(new Coordinates2D(-7, 0))); // Seven rows down
        }
    }
}

