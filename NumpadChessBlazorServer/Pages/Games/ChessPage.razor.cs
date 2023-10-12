using ChessLib.Boards;
using ChessLib.Boards.Squares.Chess;
using ChessLib.Factory;
using ChessLib.Pieces;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NumpadChessBlazorServer.Pages.Games
{
    public partial class ChessPage : ComponentBase
    {
        private IBoard<ChessBoardSquare>? board { get; set; }

        protected override Task OnInitializedAsync()
        {
            InitializeBoardAsync();
            return base.OnInitializedAsync();
        }

        private void InitializeBoardAsync()
        {
            board = GenericBoardFactory.CreateBoardOf<ChessBoardSquare>();
        }
    }
}
