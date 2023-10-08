using ChessLib.Boards.Squares;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ChessLib.Pieces.Chess
{
    public abstract class ChessPiece : Piece<ChessPiece>, IPiece
    {
        public ChessPieceType Type { get; set; }
        public ChessPieceColor Color { get; set; }

        public string ImageUrl
        {
            get
            {
                return $"/images/{Color.ToString().ToLower()}-{Type.ToString().ToLower()}.png";
            }
        }

        public ChessPiece(ChessPieceType type, ChessPieceColor color)
        {
            Type = type;
            Color = color;
        }

        public abstract IEnumerable<Coordinates2D> GetPossibleMoves();

        public override string ToString()
        {
            return $"{Color} {Type}";
        }
    }

    public enum ChessPieceType
    {
        [Description("pawn")]
        Pawn,

        [Description("rook")]
        Rook,

        [Description("knight")]
        Knight,

        [Description("bishop")]
        Bishop,

        [Description("queen")]
        Queen,

        [Description("king")]
        King
    }

    public enum ChessPieceColor
    {
        [Description("white")]
        White,

        [Description("black")]
        Black
    }
}
