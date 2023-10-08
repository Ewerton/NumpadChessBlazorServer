using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLib
{
    /// <summary>
    /// Represent the coordinates of a square on the board
    /// </summary>
    public class Coordinates2D
    {
        public int Row { get; set; }
        public int Col { get; set; }

        public Coordinates2D(int row, int col)
        {
            Row = row;
            Col = col;
        }


        #region "Operator overloading to make it easier to work with coordinates"
        public static Coordinates2D operator +(Coordinates2D a)
        {
            return new Coordinates2D(a.Row, a.Col);
        }

        public static Coordinates2D operator -(Coordinates2D a)
        {
            return new Coordinates2D(-a.Row, -a.Col);
        }

        public static Coordinates2D operator +(Coordinates2D a, Coordinates2D b)
        {
            return new Coordinates2D(a.Row + b.Row, a.Col + b.Col);
        }

        public static Coordinates2D operator -(Coordinates2D a, Coordinates2D b)
        {
            return new Coordinates2D(a.Row - b.Row, a.Col - b.Col);
        }

        #endregion

        public override string ToString()
        {
            return $"(Row: {Row} | Column: {Col})";
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (!(obj is Coordinates2D))
                return false;

            Coordinates2D coord = (Coordinates2D)obj;

            return coord.Row == Row && coord.Col == Col;
        }

        public override int GetHashCode()
        {
             return base.GetHashCode();
        }
    }
}
