using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLib.Pieces.Chess
{
    public class Knight : ChessPiece
    {
        public Knight(ChessPieceColor color) : base(ChessPieceType.Knight, color)
        {
        }

        /// <summary>
        /// Get all possible moves for knight
        /// </summary>
        /// <returns>A list of coordinates deltas for row and col</returns>
        public override IEnumerable<Coordinates2D> GetPossibleMoves()
        {
            List<Coordinates2D> possibleMoves = new List<Coordinates2D>();

            possibleMoves.Add(new Coordinates2D(-2, 1)); // Two rows down, one column right
            possibleMoves.Add(new Coordinates2D(-1, 2)); // One row down, two columns right
            possibleMoves.Add(new Coordinates2D(1, 2)); // One row up, two columns right
            possibleMoves.Add(new Coordinates2D(2, 1)); // Two rows up, one column right
            possibleMoves.Add(new Coordinates2D(2, -1)); // Two rows up, one column left
            possibleMoves.Add(new Coordinates2D(1, -2)); // One row up, two columns left
            possibleMoves.Add(new Coordinates2D(-1, -2)); // One row down, two columns left
            possibleMoves.Add(new Coordinates2D(-2, -1)); // Two rows down, one column left

            return possibleMoves;
        }
    }


}
