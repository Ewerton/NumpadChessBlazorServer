using ChessLib;
using ChessLib.Boards;
using ChessLib.Boards.Numpad;
using ChessLib.Boards.Squares.Numpad;
using ChessLib.Factory;
using ChessLib.Games;
using ChessLib.Pieces.Chess;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace NumpadChessBlazorServer.Pages
{
    public partial class NumpadChessPage : ComponentBase
    {
        [Inject]
        IJSRuntime JSRuntime { get; set; }

        private IBoard<NumpadBoardSquare>? board { get; set; }

        private int PhoneNumberLenght { get; set; } = 7;

        private Coordinates2D StartingPoint { get; set; } = new Coordinates2D(0, 0);

        private ChessPieceType SelectedChessPieceType { get; set; }

        private string ModalMessage { get; set; } = "";

        private string CoordinatesText
        {
            get
            {
                return StartingPoint != null ? StartingPoint.ToString() : "";
            }
            set
            {
                CoordinatesText = value;
            }
        }

        private EditContext EditContext;

        private string GameLog { get; set; }
        protected override async Task OnInitializedAsync()
        {
            try
            {
                InitializeBoardAsync();

                SelectedChessPieceType = ChessPieceType.Knight; // default piece type, just for testing
                PutPieceOnSquare(StartingPoint, SelectedChessPieceType);

                EditContext = new EditContext(new object());
                await base.OnInitializedAsync();
            }
            catch (Exception ex)
            {
                await ShowModal(ex.Message);
            }
        }

        private void InitializeBoardAsync()
        {
            board = GenericBoardFactory.CreateBoardOf<NumpadBoardSquare>();
        }

        private void ChessPieceTypeChanged(ChessPieceType pieceType)
        {
            SelectedChessPieceType = pieceType;
            ClearBoard();

            PutPieceOnSquare(StartingPoint, SelectedChessPieceType);
        }

        private async Task NumpadSquareClicked(NumpadBoardSquare square)
        {
            // if the * or the # button is clicked, the initial position is invalid
            bool isNumber = int.TryParse(square.Text, out int n);
            if (isNumber)
            {
                StartingPoint = board.GetCoordinatesOf(square);
                ClearBoard();
                PutPieceOnSquare(square.Coordinates, SelectedChessPieceType);
            }
            else
            {
                await ShowModal("Invalid initial position.");
            }
        }

        private void PutPieceOnSquare(Coordinates2D coord, ChessPieceType? selectedChessPieceType)
        {
            if (selectedChessPieceType.HasValue)
            {
                var selectedChessPiece = ChessPieceFactory.CreateChessPiece(selectedChessPieceType.Value, ChessPieceColor.White);
                board[coord.Row, coord.Col].SquareContent = selectedChessPiece;
            }
        }

        /// <summary>
        /// Clears all the pieces from the board
        /// </summary>
        private void ClearBoard()
        {
            for (int row = 0; row < board.RowCount; row++)
            {
                for (int col = 0; col < board.ColCount; col++)
                {
                    board[row, col].SquareContent = null;
                }
            }
        }

        private async Task ShowModal(string message)
        {
            ModalMessage = message;
            await JSRuntime.InvokeVoidAsync("ShowModal", "exampleModal");
        }

        private async void Run()
        {
            try
            {
                if (SelectedChessPieceType == null)
                {
                    await ShowModal("Please, select a chess piece.");
                    return;
                }

                if (StartingPoint == null)
                {
                    await ShowModal("Please, click at the numpad to select a starting point.");
                    return;
                }

                if (PhoneNumberLenght <= 0)
                {
                    await ShowModal("Please, enter a valid lenght for the phone number.");
                    return;
                }

                GameLog = String.Empty;
                NumpadBoard gameBoard = board as NumpadBoard;
                NumpadChessGame game = new NumpadChessGame(gameBoard);

                game.NewNumberDiscovered += Game_NewNumberDiscovered;

                await UpdateGameLog($"Starting game at number {gameBoard[StartingPoint.Row, StartingPoint.Col].Text} (row:{StartingPoint.Row}, col:{StartingPoint.Col}) for {SelectedChessPieceType.ToString()} piece ...");

                // Calls the recursive method to find the phone numbers
                List<string> discoveredPhoneNumbers = game.GetUniquePhoneNumbers(SelectedChessPieceType, StartingPoint, PhoneNumberLenght);

                string endingMessge = "Game finished.";
                
                if (discoveredPhoneNumbers.Count > 0)
                    endingMessge = $"Game finished. {discoveredPhoneNumbers.Count} unique phone numbers found.";
                else
                    endingMessge = $"Game finished. No unique phone numbers found.";
                
                await UpdateGameLog(endingMessge);
                await ShowModal(endingMessge);
            }
            catch (Exception ex)
            {
                await ShowModal(ex.Message);
            }
        }


        private void Game_NewNumberDiscovered(object? sender, string newNumber)
        {
            Task.Run(async () => await UpdateGameLog(newNumber));
        }

        private async Task UpdateGameLog(string newNumber)
        {
            GameLog = GameLog + newNumber + Environment.NewLine;
            StateHasChanged();
        }
    }
}
