﻿using ChessLib.Boards.Squares;
using ChessLib.Pieces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLib.Boards
{
    public interface IBoard<T> where T : IBoardSquare
    {
        public int RowCount { get; }
        public int ColCount { get; }

        public T this[int row, int col] { get; set; }

        Coordinates2D? GetCoordinatesOf(T square);
    }

}
