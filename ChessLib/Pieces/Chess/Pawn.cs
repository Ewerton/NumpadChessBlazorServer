using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLib.Pieces.Chess
{
    public class Pawn : ChessPiece
    {
        public Pawn(ChessPieceColor color) : base(ChessPieceType.Pawn, color)
        {
        }

        /// <summary>
        /// Get all possible moves for a Pawn
        /// </summary>
        /// <returns>A list of coordinates deltas for row and col</returns>
        public override IEnumerable<Coordinates2D> GetPossibleMoves()
        {
            List<Coordinates2D> possibleMoves = new List<Coordinates2D>();

            possibleMoves.Add(new Coordinates2D(1, 0)); // move forward one square
            possibleMoves.Add(new Coordinates2D(2, 0)); // move forward two squares
            possibleMoves.Add(new Coordinates2D(1, 1)); // move diagonally right
            possibleMoves.Add(new Coordinates2D(1, -1)); // move diagonally left


            return possibleMoves;
        }
    }


}
