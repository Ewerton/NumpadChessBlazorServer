using ChessLib.Boards.Squares;
using ChessLib.Pieces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ChessLib.Boards
{
    public abstract class BaseBoard<TBoardSquare> : IBoard<TBoardSquare> where TBoardSquare : IBoardSquare
    {
        public readonly int _rowCount = 0;
        public readonly int _colCount = 0;

        public readonly TBoardSquare[,] board; // using an generic array to reuse this base class to any derived board whit any piece which implements IPiece.

        public BaseBoard(int rowCount, int colCount)
        {
            _rowCount = rowCount;
            _colCount = colCount;
            board = new TBoardSquare[rowCount, colCount];
        }

        public TBoardSquare this[int row, int col]
        {
            get
            {
                return board[row, col];
            }
            set
            {
                board[row, col] = value;
            }
        }

        public Coordinates2D? GetCoordinatesOf(TBoardSquare square)
        {
            for (var row = 0; row < _rowCount; row++)
            {
                for (var col = 0; col < _colCount; col++)
                {
                    if (board[row, col].Equals(square))
                    {
                        return new Coordinates2D(row, col);
                    }
                }
            }

            return null;
        }

        public int RowCount { get { return _rowCount; } }

        public int ColCount { get { return _colCount; } }
    }
}
