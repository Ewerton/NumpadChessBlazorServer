using ChessLib.Boards.Squares.Numpad;
using ChessLib.Pieces;
using ChessLib.Pieces.Chess;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NumpadChessBlazorServer.Pages.Components
{
    public partial class CmpNumpadButton : ComponentBase
    {
        [Parameter]
        public NumpadBoardSquare? Square { get; set; }

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

        private bool Debug
        {
            get
            {
#if DEBUG
                return true;
#else
                 return false;
#endif

            }
        }

        [Parameter]
        public EventCallback<NumpadBoardSquare> SquareClicked { get; set; }


        protected override Task OnInitializedAsync()
        {
            return base.OnInitializedAsync();
        }

        private void Clicked()
        {
            SquareClicked.InvokeAsync(Square);
        }
    }
}
