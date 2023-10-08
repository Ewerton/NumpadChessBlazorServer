using ChessLib.Boards.Squares.Chess;
using ChessLib.Pieces.Chess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLib.Boards.Chess
{
    public class ChessBoard : BaseBoard<ChessBoardSquare>, IBoard<ChessBoardSquare>
    {
        public ChessBoard() : base(8, 8)
        {
            InitializeBoard();
        }

        /// <summary>
        /// Initialize a chess board with pieces in their starting positions
        /// </summary>
        private void InitializeBoard()
        {
            SetSquaresOnTheBoard();
            PlaceBlackPiecesOnTheBoard();
            PlaceWhitePiecesOnTheBoard();
        }


        /// <summary>
        /// Creates the squares on the board toogling between black and white
        /// </summary>
        private void SetSquaresOnTheBoard()
        {
            ChessBoardSquareColor currentColor = ChessBoardSquareColor.White;
            for (int row = 0; row < RowCount; row++)
            {              
                for (int col = 0; col < ColCount; col++)
                {
                    bool isEvenRow = row % 2 == 0;
                    if (isEvenRow)
                        currentColor = ChessBoardSquareColor.White;
                    else
                    {
                        if (currentColor == ChessBoardSquareColor.White)
                            currentColor = ChessBoardSquareColor.Black;
                        else
                            currentColor = ChessBoardSquareColor.White;
                    }

                    board[row, col] = new ChessBoardSquare(row, col, currentColor);
                }
            }
        }

        private void PlaceBlackPiecesOnTheBoard()
        {
            board[0, 0].SquareContent = new Rook(ChessPieceColor.Black);
            board[0, 1].SquareContent = new Knight( ChessPieceColor.Black);
            board[0, 2].SquareContent = new Bishop(ChessPieceColor.Black);
            board[0, 3].SquareContent = new Queen(ChessPieceColor.Black);
            board[0, 4].SquareContent = new King(ChessPieceColor.Black);
            board[0, 5].SquareContent = new Bishop(ChessPieceColor.Black);
            board[0, 6].SquareContent = new Knight(ChessPieceColor.Black);
            board[0, 7].SquareContent = new Rook(ChessPieceColor.Black);

            // The black pawn line
            for (int i = 0; i < ColCount; i++)
            {
                board[1, i].SquareContent = new Pawn(ChessPieceColor.Black);
            }
        }

        private void PlaceWhitePiecesOnTheBoard()
        {
            board[7, 0].SquareContent = new Rook(ChessPieceColor.White);
            board[7, 1].SquareContent = new Knight(ChessPieceColor.White);
            board[7, 2].SquareContent = new Bishop(ChessPieceColor.White);
            board[7, 3].SquareContent = new Queen(ChessPieceColor.White);
            board[7, 4].SquareContent = new King(ChessPieceColor.White);
            board[7, 5].SquareContent = new Bishop(ChessPieceColor.White);
            board[7, 6].SquareContent = new Knight(ChessPieceColor.White);
            board[7, 7].SquareContent = new Rook(ChessPieceColor.White);

            // The black pawn line
            for (int i = 0; i < ColCount; i++)
            {
                board[6, i].SquareContent = new Pawn(ChessPieceColor.White);
            }
        }
    }
}
