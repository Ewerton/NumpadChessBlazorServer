using ChessLib.Pieces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ChessLib.Boards.Squares.Chess
{
    public class ChessBoardSquare : BaseBoardSquare, IBoardSquare
    {
        public ChessBoardSquareColor Color { get; set; }

        public ChessBoardSquare(int row, int col, ChessBoardSquareColor color) : base(row, col)
        {
            Color = color;
        }

        public ChessBoardSquare(Coordinates2D coord, ChessBoardSquareColor color) : base(coord.Row, coord.Col)
        {
            Color = color;
        }
    }

    public enum ChessBoardSquareColor
    {
        [Description("white")]
        White,

        [Description("black")]
        Black
    }
}
