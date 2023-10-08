using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLib.Pieces.Chess
{
    public class King : ChessPiece
    {
        public King(ChessPieceColor color) : base(ChessPieceType.King, color)
        {
        }

        /// <summary>
        /// Get all possible moves for the King
        /// </summary>
        /// <returns>A list of coordinates deltas for row and col</returns>
        public override IEnumerable<Coordinates2D> GetPossibleMoves()
        {
            List<Coordinates2D> possibleMoves = new List<Coordinates2D>();

            possibleMoves.Add(new Coordinates2D(0, 1)); // One column right
            possibleMoves.Add(new Coordinates2D(0, -1)); // One column left
            possibleMoves.Add(new Coordinates2D(1, 0)); // One row up
            possibleMoves.Add(new Coordinates2D(-1, 0)); // One row down

            return possibleMoves;
        }
    }


}
