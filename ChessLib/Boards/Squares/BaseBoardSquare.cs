using ChessLib.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLib.Boards.Squares
{
    public abstract class BaseBoardSquare : IBoardSquare
    {
        public Coordinates2D Coordinates { get; set; } = new(0,0);
        public virtual IPiece? SquareContent { get; set; }

        public BaseBoardSquare(int row, int col)
        {
            Coordinates.Row = row;
            Coordinates.Col = col;
        }

        public BaseBoardSquare(Coordinates2D coord)
        {
            Coordinates.Row = coord.Row;
            Coordinates.Col = coord.Col;
        }

        public override string ToString()
        {
            return $"({Coordinates.Row}, {Coordinates.Col})";
        }
    }
}
