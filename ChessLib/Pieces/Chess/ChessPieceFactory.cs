using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLib.Pieces.Chess
{
    public static class ChessPieceFactory
    {
        public static ChessPiece CreateChessPiece(ChessPieceType chessPieceType, ChessPieceColor chessPieceColor)
        {
            switch (chessPieceType)
            {
                case ChessPieceType.King:
                    return new King(chessPieceColor);
                case ChessPieceType.Queen:
                    return new Queen(chessPieceColor);
                case ChessPieceType.Rook:
                    return new Rook(chessPieceColor);
                case ChessPieceType.Bishop:
                    return new Bishop(chessPieceColor);
                case ChessPieceType.Knight:
                    return new Knight(chessPieceColor);
                case ChessPieceType.Pawn:
                    return new Pawn(chessPieceColor);
                default:
                    throw new ArgumentException("Invalid chess piece type");
            }
        }
    }
}
