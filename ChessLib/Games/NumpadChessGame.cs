using ChessLib.Boards;
using ChessLib.Boards.Numpad;
using ChessLib.Pieces.Chess;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLib.Games
{
    public class NumpadChessGame
    {
        public event EventHandler<string> OnNewNumberDiscovered;

        public readonly NumpadBoard GameBoard;// { get; set; }

        public ChessPiece? SelectedChessPiece { get; private set; }
        public int PhoneNumberSize  { get; private set; }

        List<string> PhoneNumbers = new List<string>();


        public NumpadChessGame(NumpadBoard gameBoard)
        {
            if (gameBoard == null)
                throw new ArgumentNullException(nameof(gameBoard));

            if (NoPieceOnTheBoard(gameBoard))
                throw new Exception("No piece on the board. Please put a piece on the board first.");

            GameBoard = gameBoard;
        }

        public List<string> GetUniquePhoneNumbers(ChessPieceType chessPieceType, Coordinates2D startingPoint, int phoneNumberSize)
        {
            if (!AreCoordinatesWithinBoard(startingPoint))
                throw new ArgumentException("Starting point is outside the board.");

            if (AreCoordinatesAtInvalidPosition(startingPoint))
                throw new Exception("Starting point is in an invalid position.");

            if (IsZeroOrOne(startingPoint))
                throw new Exception("Phone number cannot start with zero or one.");

            if (phoneNumberSize <= 0)
                throw new ArgumentException("Phone number size must be greater than zero.");

            PhoneNumberSize = phoneNumberSize;
            SelectedChessPiece = ChessPieceFactory.CreateChessPiece(chessPieceType, ChessPieceColor.White);

            PhoneNumbers = new List<string>();

            string currentNumber = GameBoard[startingPoint.Row, startingPoint.Col].Text.ToString();

            //Recursively try to find phone numbers
            GeneratePhoneNumbers(currentNumber, startingPoint, PhoneNumbers);

            return PhoneNumbers;
        }

        private void GeneratePhoneNumbers(string currentNumber, Coordinates2D currentSquare, List<string> phoneNumbers)
        {
            if (currentNumber.Length == 7)
            {
                if (!PhoneNumbers.Contains(currentNumber))
                {
                    PhoneNumbers.Add(currentNumber);
                    OnNewNumberDiscovered?.Invoke(this, currentNumber);
                    return;
                }
            }
            foreach (Coordinates2D nextSquare in ValidMovesFrom(currentSquare))
            {
                var newDigit = GameBoard[nextSquare.Row, nextSquare.Col].Text;
                string newNumber = currentNumber + newDigit;
                GeneratePhoneNumbers(newNumber, nextSquare, phoneNumbers);
            }
        }

        private List<Coordinates2D> ValidMovesFrom(Coordinates2D startingPoint)
        {
            List<Coordinates2D> validMoves = new List<Coordinates2D>();

            foreach (var possibleMove in SelectedChessPiece.GetPossibleMoves())
            {
                Coordinates2D destination = startingPoint + possibleMove;
                if (!AreCoordinatesAtInvalidPosition(destination))
                    validMoves.Add(destination);
            }

            return validMoves;
        }

        private bool NoPieceOnTheBoard(NumpadBoard board)
        {
            bool noPieceOnTheBoard = true;
            for (int row = 0; row < board.RowCount; row++)
            {
                for (int col = 0; col < board.ColCount; col++)
                {
                    if (board[row, col].SquareContent != null)
                        noPieceOnTheBoard = false;
                }
            }

            return noPieceOnTheBoard;
        }

        private bool AreCoordinatesWithinBoard(Coordinates2D coord)
        {
            bool rowValid = (coord.Row >= 0 && coord.Row <= GameBoard.RowCount - 1);
            bool colValid = (coord.Col >= 0 && coord.Col <= GameBoard.ColCount - 1);

            return rowValid && colValid;
        }

        private bool AreCoordinatesAtInvalidPosition(Coordinates2D coord)
        {
            bool invalidCoordinates = true;
            if (AreCoordinatesWithinBoard(coord))
            {
                var square = GameBoard[coord.Row, coord.Col];
                if (square == null)
                    invalidCoordinates = true;

                invalidCoordinates = square.IsInvalid;
            }
            return invalidCoordinates;
        }

        private bool IsZeroOrOne(Coordinates2D startingPoint)
        {
            return GameBoard[startingPoint.Row, startingPoint.Col].Text == "0" ||
                   GameBoard[startingPoint.Row, startingPoint.Col].Text == "1";
        }


    }
}
