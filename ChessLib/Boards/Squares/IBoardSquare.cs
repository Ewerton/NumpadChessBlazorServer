using ChessLib.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLib.Boards.Squares
{
    public interface IBoardSquare
    {
        Coordinates2D Coordinates { get; set; }

        /// <summary>
        /// Represent the contents of one square on the board, it can be a chess piece or anything which implement IPiece
        /// </summary>
        IPiece? SquareContent { get; set; }
    }
}
