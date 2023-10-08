using ChessLib.Boards;
using ChessLib.Boards.Chess;
using ChessLib.Boards.Numpad;
using ChessLib.Boards.Squares;
using ChessLib.Boards.Squares.Chess;
using ChessLib.Boards.Squares.Numpad;
using ChessLib.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLib.Factory
{
    public static class GenericBoardFactory
    {
        public static IBoard<T> CreateBoardOf<T>() where T : IBoardSquare
        {
            switch (typeof(T))
            {
                case Type t when t == typeof(ChessBoardSquare):
                    return ((IBoard<T>)new ChessBoard());
                case Type t when t == typeof(NumpadBoardSquare):
                     return ((IBoard<T>)new NumpadBoard());
                default:
                    throw new System.ArgumentException("Board factory not found.");
            }
        }
       
    }
}
