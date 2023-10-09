using ChessLib.Boards.Numpad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumpadChessUnitTests.BoardsTests
{
    public class NumpadBoard_Tests
    {
        [Test]
        public void GetPossibleMoves()
        {
            // Arrange
            var numpadBoard = new NumpadBoard();

            // Act


            // Assert
            Assert.That(numpadBoard.RowCount, Is.EqualTo(4));
            Assert.That(numpadBoard.ColCount, Is.EqualTo(3));
            Assert.That(numpadBoard.TotalValidPositionsCount, Is.EqualTo(12 - 2)); // * and # should not be counted as valid positions

            Assert.That(numpadBoard[3, 0].IsInvalid, Is.True);
            Assert.That(numpadBoard[3, 2].IsInvalid, Is.True);

        }
    }
}
