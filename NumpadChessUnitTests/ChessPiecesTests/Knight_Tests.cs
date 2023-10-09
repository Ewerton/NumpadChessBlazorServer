using ChessLib;
using ChessLib.Pieces.Chess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumpadChessUnitTests.ChessPiecesTests
{
    public class Knight_Tests
    {
        // generate the tests for ChessLib.Pieces.Chess.Knight
        [Test]
        public void GetPossibleMoves()
        {
            // Arrange
            var knight = new Knight(ChessPieceColor.White);

            // Act
            var possibleMoves = knight.GetPossibleMoves();

            // Assert
            Assert.That(possibleMoves.Count(), Is.EqualTo(8));
            Assert.IsTrue(possibleMoves.Contains(new Coordinates2D(-2, 1)));
            Assert.IsTrue(possibleMoves.Contains(new Coordinates2D(-1, 2)));
            Assert.IsTrue(possibleMoves.Contains(new Coordinates2D(1, 2)));
            Assert.IsTrue(possibleMoves.Contains(new Coordinates2D(2, 1)));
            Assert.IsTrue(possibleMoves.Contains(new Coordinates2D(2, -1)));
            Assert.IsTrue(possibleMoves.Contains(new Coordinates2D(1, -2)));
            Assert.IsTrue(possibleMoves.Contains(new Coordinates2D(-1, -2)));
            Assert.IsTrue(possibleMoves.Contains(new Coordinates2D(-2, -1)));
        }
    }
}
