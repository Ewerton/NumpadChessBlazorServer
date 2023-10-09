using ChessLib;
using ChessLib.Pieces.Chess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumpadChessUnitTests.ChessPiecesTests
{
    public class Bishop_Tests
    {
        [Test]
        public void GetPossibleMoves()
        {
            // Arrange
            var bishop = new Bishop(ChessPieceColor.White);

            // Act
            var possibleMoves = bishop.GetPossibleMoves();

            // Assert
            Assert.That(possibleMoves.Count(), Is.EqualTo(28));

            // Diagonally towards top-right
            Assert.IsTrue(possibleMoves.Contains(new Coordinates2D(1, 1))); // One row up, one column right
            Assert.IsTrue(possibleMoves.Contains(new Coordinates2D(2, 2))); // Two rows up, two columns right
            Assert.IsTrue(possibleMoves.Contains(new Coordinates2D(3, 3))); // Three rows up, three columns right
            Assert.IsTrue(possibleMoves.Contains(new Coordinates2D(4, 4))); // Four rows up, four columns right
            Assert.IsTrue(possibleMoves.Contains(new Coordinates2D(5, 5))); // Five rows up, five columns right
            Assert.IsTrue(possibleMoves.Contains(new Coordinates2D(6, 6))); // Six rows up, six columns right
            Assert.IsTrue(possibleMoves.Contains(new Coordinates2D(7, 7))); // Seven rows up, seven columns right

            // Diagonally towards bottom-left
            Assert.IsTrue(possibleMoves.Contains(new Coordinates2D(-1, -1))); // One row down, one column left
            Assert.IsTrue(possibleMoves.Contains(new Coordinates2D(-2, -2))); // Two rows down, two columns left
            Assert.IsTrue(possibleMoves.Contains(new Coordinates2D(-3, -3))); // Three rows down, three columns left
            Assert.IsTrue(possibleMoves.Contains(new Coordinates2D(-4, -4))); // Four rows down, four columns left
            Assert.IsTrue(possibleMoves.Contains(new Coordinates2D(-5, -5))); // Five rows down, five columns left
            Assert.IsTrue(possibleMoves.Contains(new Coordinates2D(-6, -6))); // Six rows down, six columns left
            Assert.IsTrue(possibleMoves.Contains(new Coordinates2D(-7, -7))); // Seven rows down, seven columns left

            // Diagonally towards top-left
            Assert.IsTrue(possibleMoves.Contains(new Coordinates2D(1, -1))); // One row up, one column left
            Assert.IsTrue(possibleMoves.Contains(new Coordinates2D(2, -2))); // Two rows up, two columns left
            Assert.IsTrue(possibleMoves.Contains(new Coordinates2D(3, -3))); // Three rows up, three columns left
            Assert.IsTrue(possibleMoves.Contains(new Coordinates2D(4, -4))); // Four rows up, four columns left
            Assert.IsTrue(possibleMoves.Contains(new Coordinates2D(5, -5))); // Five rows up, five columns left
            Assert.IsTrue(possibleMoves.Contains(new Coordinates2D(6, -6))); // Six rows up, six columns left
            Assert.IsTrue(possibleMoves.Contains(new Coordinates2D(7, -7))); // Seven rows up, seven columns left

            // Diagonally towards bottom-right
            Assert.IsTrue(possibleMoves.Contains(new Coordinates2D(-1, 1))); // One row down, one column right
            Assert.IsTrue(possibleMoves.Contains(new Coordinates2D(-2, 2))); // Two rows down, two columns right
            Assert.IsTrue(possibleMoves.Contains(new Coordinates2D(-3, 3))); // Three rows down, three columns right
            Assert.IsTrue(possibleMoves.Contains(new Coordinates2D(-4, 4))); // Four rows down, four columns right
            Assert.IsTrue(possibleMoves.Contains(new Coordinates2D(-5, 5))); // Five rows down, five columns right
            Assert.IsTrue(possibleMoves.Contains(new Coordinates2D(-6, 6))); // Six rows down, six columns right
            Assert.IsTrue(possibleMoves.Contains(new Coordinates2D(-7, 7))); // Seven rows down, seven columns right


        }
    }
}
