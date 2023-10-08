using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLib.Pieces.Chess
{
    public class Queen : ChessPiece
    {
        public Queen(ChessPieceColor color) : base(ChessPieceType.Queen, color)
        {
        }

        /// <summary>
        /// Get all possible moves for the Queen
        /// </summary>
        /// <returns>A list of coordinates deltas for row and col</returns>
        public override IEnumerable<Coordinates2D> GetPossibleMoves()
        {
            List<Coordinates2D> possibleMoves = new List<Coordinates2D>();

            // Could be done with a loop, but this is more readable

            //To the right
            possibleMoves.Add(new Coordinates2D(0, 1)); // One column right
            possibleMoves.Add(new Coordinates2D(0, 2)); // Two columns right
            possibleMoves.Add(new Coordinates2D(0, 3)); // Three columns right
            possibleMoves.Add(new Coordinates2D(0, 4)); // Four columns right
            possibleMoves.Add(new Coordinates2D(0, 5)); // Five columns right
            possibleMoves.Add(new Coordinates2D(0, 6)); // Six columns right
            possibleMoves.Add(new Coordinates2D(0, 7)); // Seven columns right

            //To the left
            possibleMoves.Add(new Coordinates2D(0, -1)); // One column left
            possibleMoves.Add(new Coordinates2D(0, -2)); // Two columns left
            possibleMoves.Add(new Coordinates2D(0, -3)); // Three columns left
            possibleMoves.Add(new Coordinates2D(0, -4)); // Four columns left
            possibleMoves.Add(new Coordinates2D(0, -5)); // Five columns left
            possibleMoves.Add(new Coordinates2D(0, -6)); // Six columns left
            possibleMoves.Add(new Coordinates2D(0, -7)); // Seven columns left

            // Up
            possibleMoves.Add(new Coordinates2D(1, 0)); // One row up
            possibleMoves.Add(new Coordinates2D(2, 0)); // Two rows up
            possibleMoves.Add(new Coordinates2D(3, 0)); // Three rows up
            possibleMoves.Add(new Coordinates2D(4, 0)); // Four rows up
            possibleMoves.Add(new Coordinates2D(5, 0)); // Five rows up
            possibleMoves.Add(new Coordinates2D(6, 0)); // Six rows up
            possibleMoves.Add(new Coordinates2D(7, 0)); // Seven rows up

            // Down
            possibleMoves.Add(new Coordinates2D(-1, 0)); // One row down
            possibleMoves.Add(new Coordinates2D(-2, 0)); // Two rows down
            possibleMoves.Add(new Coordinates2D(-3, 0)); // Three rows down
            possibleMoves.Add(new Coordinates2D(-4, 0)); // Four rows down
            possibleMoves.Add(new Coordinates2D(-5, 0)); // Five rows down
            possibleMoves.Add(new Coordinates2D(-6, 0)); // Six rows down
            possibleMoves.Add(new Coordinates2D(-7, 0)); // Seven rows down

            // Diagonally towards top-right  
            possibleMoves.Add(new Coordinates2D(1, 1)); // One row up, one column right
            possibleMoves.Add(new Coordinates2D(2, 2)); // Two rows up, two columns right
            possibleMoves.Add(new Coordinates2D(3, 3)); // Three rows up, three columns right
            possibleMoves.Add(new Coordinates2D(4, 4)); // Four rows up, four columns right
            possibleMoves.Add(new Coordinates2D(5, 5)); // Five rows up, five columns right
            possibleMoves.Add(new Coordinates2D(6, 6)); // Six rows up, six columns right
            possibleMoves.Add(new Coordinates2D(7, 7)); // Seven rows up, seven columns right

            // Diagonally towards bottom-left
            possibleMoves.Add(new Coordinates2D(-1, -1)); // One row down, one column left
            possibleMoves.Add(new Coordinates2D(-2, -2)); // Two rows down, two columns left
            possibleMoves.Add(new Coordinates2D(-3, -3)); // Three rows down, three columns left
            possibleMoves.Add(new Coordinates2D(-4, -4)); // Four rows down, four columns left
            possibleMoves.Add(new Coordinates2D(-5, -5)); // Five rows down, five columns left
            possibleMoves.Add(new Coordinates2D(-6, -6)); // Six rows down, six columns left
            possibleMoves.Add(new Coordinates2D(-7, -7)); // Seven rows down, seven columns left

            // Diagonally towards top-left
            possibleMoves.Add(new Coordinates2D(1, -1)); // One row up, one column left
            possibleMoves.Add(new Coordinates2D(2, -2)); // Two rows up, two columns left
            possibleMoves.Add(new Coordinates2D(3, -3)); // Three rows up, three columns left
            possibleMoves.Add(new Coordinates2D(4, -4)); // Four rows up, four columns left
            possibleMoves.Add(new Coordinates2D(5, -5)); // Five rows up, five columns left
            possibleMoves.Add(new Coordinates2D(6, -6)); // Six rows up, six columns left
            possibleMoves.Add(new Coordinates2D(7, -7)); // Seven rows up, seven columns left

            // Diagonally towards bottom-right
            possibleMoves.Add(new Coordinates2D(-1, 1)); // One row down, one column right
            possibleMoves.Add(new Coordinates2D(-2, 2)); // Two rows down, two columns right
            possibleMoves.Add(new Coordinates2D(-3, 3)); // Three rows down, three columns right
            possibleMoves.Add(new Coordinates2D(-4, 4)); // Four rows down, four columns right
            possibleMoves.Add(new Coordinates2D(-5, 5)); // Five rows down, five columns right
            possibleMoves.Add(new Coordinates2D(-6, 6)); // Six rows down, six columns right
            possibleMoves.Add(new Coordinates2D(-7, 7)); // Seven rows down, seven columns right

           


            return possibleMoves;
        }
    }


}
