using ChessLib.Pieces.Chess;
using ChessLib;

namespace NumpadChessUnitTests.ChessPiecesTests
{
    public class Pawn_Tests
    {
        [Test]
        public void GetPossibleMoves()
        {
            // Arrange
            var rook = new Pawn(ChessPieceColor.White);

            // Act
            var possibleMoves = rook.GetPossibleMoves();

            // Assert
            Assert.That(possibleMoves.Count(), Is.EqualTo(4));

            Assert.That(possibleMoves.Contains(new Coordinates2D(1, 0))); // move forward one square
            Assert.That(possibleMoves.Contains(new Coordinates2D(2, 0))); // move forward two squares
            Assert.That(possibleMoves.Contains(new Coordinates2D(1, 1))); // move diagonally right
            Assert.That(possibleMoves.Contains(new Coordinates2D(1, -1))); // move diagonally left

        }
    }
}

