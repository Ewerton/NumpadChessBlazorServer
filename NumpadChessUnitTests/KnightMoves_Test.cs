using ChessLib;
using ChessLib.Pieces.Chess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumpadChessUnitTests
{
    public class KnightMoves_Test
    {
        [Test]
        public void MovesFrom00()
        {
            // starting from 0,0 the knight can move to 1,2 and 2,1

            ChessPiece SelectedChessPiece = ChessPieceFactory.CreateChessPiece(ChessPieceType.Knight , ChessPieceColor.White);
            Coordinates2D startingPoint = new Coordinates2D(0, 0);
            List<Coordinates2D> ValidDestinations = new List<Coordinates2D>();
            foreach (var possibleMove in SelectedChessPiece.GetPossibleMoves())
            {
                Coordinates2D destination = startingPoint + possibleMove;
                if (destination.Row >= 0 && destination.Row <= 7 && destination.Col >= 0 && destination.Col <= 7)
                {
                    ValidDestinations.Add(destination);
                }
            }
        }
    }
}
