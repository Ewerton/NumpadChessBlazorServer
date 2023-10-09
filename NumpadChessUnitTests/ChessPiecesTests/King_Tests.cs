using ChessLib.Pieces.Chess;
using ChessLib;

namespace NumpadChessUnitTests.ChessPiecesTests
{
    public class King_Tests
    {
        [Test]
        public void GetPossibleMoves()
        {
            // Arrange
            var king = new King(ChessPieceColor.White);

            // Act
            var possibleMoves = king.GetPossibleMoves();

            // Assert
            Assert.That(possibleMoves.Count(), Is.EqualTo(8));
            Assert.IsTrue(possibleMoves.Contains(new Coordinates2D(1, 1)));
            Assert.IsTrue(possibleMoves.Contains(new Coordinates2D(0, 1)));
            Assert.IsTrue(possibleMoves.Contains(new Coordinates2D(-1, 1)));
            Assert.IsTrue(possibleMoves.Contains(new Coordinates2D(-1, 0)));
            Assert.IsTrue(possibleMoves.Contains(new Coordinates2D(-1, -1)));
            Assert.IsTrue(possibleMoves.Contains(new Coordinates2D(0, -1)));
            Assert.IsTrue(possibleMoves.Contains(new Coordinates2D(1, -1)));
            Assert.IsTrue(possibleMoves.Contains(new Coordinates2D(1, 0)));
        }
    }
}

