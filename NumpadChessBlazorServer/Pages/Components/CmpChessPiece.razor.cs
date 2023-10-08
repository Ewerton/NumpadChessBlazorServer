using ChessLib.Boards.Squares.Chess;
using ChessLib.Pieces.Chess;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NumpadChessBlazorServer.Pages.Components
{
    public partial class CmpChessPiece : ComponentBase
    {
        [Parameter]
        public ChessBoardSquare? Square { get; set;}

        public ChessPiece? Piece 
        {
            get
            { 
                return Square?.SquareContent as ChessPiece;
            }
            set
            { 
                Piece = value;
            }
        }

        protected override Task OnInitializedAsync()
        {
            return base.OnInitializedAsync();
        }

    }
}
