using ChessLib.Pieces.Chess;
using ChessLib;

namespace NumpadChessUnitTests.ChessPiecesTests
{
    public class Queen_Tests
    {
        [Test]
        public void GetPossibleMoves()
        {
            // Arrange
            var queen = new Queen(ChessPieceColor.White);

            // Act
            var possibleMoves = queen.GetPossibleMoves();

            // Assert
            Assert.That(possibleMoves.Count(), Is.EqualTo(56));
            //To the right
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

            // Diagonally towards top-right  
            Assert.That(possibleMoves.Contains(new Coordinates2D(1, 1))); // One row up, one column right
            Assert.That(possibleMoves.Contains(new Coordinates2D(2, 2))); // Two rows up, two columns right
            Assert.That(possibleMoves.Contains(new Coordinates2D(3, 3))); // Three rows up, three columns right
            Assert.That(possibleMoves.Contains(new Coordinates2D(4, 4))); // Four rows up, four columns right
            Assert.That(possibleMoves.Contains(new Coordinates2D(5, 5))); // Five rows up, five columns right
            Assert.That(possibleMoves.Contains(new Coordinates2D(6, 6))); // Six rows up, six columns right
            Assert.That(possibleMoves.Contains(new Coordinates2D(7, 7))); // Seven rows up, seven columns right

            // Diagonally towards bottom-left
            Assert.That(possibleMoves.Contains(new Coordinates2D(-1, -1))); // One row down, one column left
            Assert.That(possibleMoves.Contains(new Coordinates2D(-2, -2))); // Two rows down, two columns left
            Assert.That(possibleMoves.Contains(new Coordinates2D(-3, -3))); // Three rows down, three columns left
            Assert.That(possibleMoves.Contains(new Coordinates2D(-4, -4))); // Four rows down, four columns left
            Assert.That(possibleMoves.Contains(new Coordinates2D(-5, -5))); // Five rows down, five columns left
            Assert.That(possibleMoves.Contains(new Coordinates2D(-6, -6))); // Six rows down, six columns left
            Assert.That(possibleMoves.Contains(new Coordinates2D(-7, -7))); // Seven rows down, seven columns left

            // Diagonally towards top-left)
            Assert.That(possibleMoves.Contains(new Coordinates2D(1, -1))); // One row up, one column left
            Assert.That(possibleMoves.Contains(new Coordinates2D(2, -2))); // Two rows up, two columns left
            Assert.That(possibleMoves.Contains(new Coordinates2D(3, -3))); // Three rows up, three columns left
            Assert.That(possibleMoves.Contains(new Coordinates2D(4, -4))); // Four rows up, four columns left
            Assert.That(possibleMoves.Contains(new Coordinates2D(5, -5))); // Five rows up, five columns left
            Assert.That(possibleMoves.Contains(new Coordinates2D(6, -6))); // Six rows up, six columns left
            Assert.That(possibleMoves.Contains(new Coordinates2D(7, -7))); // Seven rows up, seven columns left

            // Diagonally towards bottom-right)
            Assert.That(possibleMoves.Contains(new Coordinates2D(-1, 1))); // One row down, one column right
            Assert.That(possibleMoves.Contains(new Coordinates2D(-2, 2))); // Two rows down, two columns right
            Assert.That(possibleMoves.Contains(new Coordinates2D(-3, 3))); // Three rows down, three columns right
            Assert.That(possibleMoves.Contains(new Coordinates2D(-4, 4))); // Four rows down, four columns right
            Assert.That(possibleMoves.Contains(new Coordinates2D(-5, 5))); // Five rows down, five columns right
            Assert.That(possibleMoves.Contains(new Coordinates2D(-6, 6))); // Six rows down, six columns right
            Assert.That(possibleMoves.Contains(new Coordinates2D(-7, 7))); // Seven rows down, seven columns right
        }
    }
}

