using ChessLib.Boards.Squares.Chess;
using ChessLib.Boards.Squares.Numpad;
using ChessLib.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLib.Boards.Numpad
{
    /// <summary>
    /// Represents a cellphone numpad board
    /// </summary>
    public class NumpadBoard : BaseBoard<NumpadBoardSquare>, IBoard<NumpadBoardSquare>
    {
        public NumpadBoard() : base(4, 3)
        {
            InitializeBoard();
        }

        /// <summary>
        /// Returns the total number of valid positions (m * n) on the board discarded the invalid positions
        /// </summary>
        public int TotalValidPositionsCount
        {
            get
            {
                return board.Cast<NumpadBoardSquare>().Where(x => !x.IsInvalid).Count();
            }
        }

        /// <summary>
        /// Initializes the numpad board
        /// </summary>
        private void InitializeBoard()
        {
            SetSquaresOnTheBoard();
        }
        private void SetSquaresOnTheBoard()
        {
            int numCount = 0;
            for (int row = 0; row < RowCount; row++)
            {
                for (int col = 0; col < ColCount; col++)
                {
                    bool bootomLeft = row == 3 && col == 0;
                    bool bottomRight = row == 3 && col == 2;
                    bool bottomCenter = row == 3 && col == 1;
                    if (bootomLeft)
                        board[row, col] = new NumpadBoardSquare(row, col, "*", isInvalid: true);
                    else
                    if (bottomRight)
                        board[row, col] = new NumpadBoardSquare(row, col, "#", isInvalid: true);
                    else
                    if (bottomCenter)
                        board[row, col] = new NumpadBoardSquare(row, col, "0");
                    else
                    {
                        numCount++;
                        board[row, col] = new NumpadBoardSquare(row, col, numCount.ToString());
                    }

                }
            }
        }
    }
}
