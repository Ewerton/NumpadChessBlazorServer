using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace ChessLib.Boards.Squares.Numpad
{
    public class NumpadBoardSquare : BaseBoardSquare, IBoardSquare
    {
        public string Text { get; set; }
        
        /// <summary>
        /// To indicate that this is an invalid position (used for the * and the # for example)
        /// </summary>
        public bool IsInvalid { get; set; }

        public NumpadBoardSquare(int row, int col, string text, bool isInvalid = false) : base(row, col)
        {
            Text = text;
            IsInvalid = isInvalid;
        }

        public NumpadBoardSquare(Coordinates2D coord, string text, bool isInvalid = false) : base(coord.Row, coord.Col)
        {
            Text = text;
            IsInvalid = isInvalid;
        }
    }


}
