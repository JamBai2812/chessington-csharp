﻿using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Pawn : Piece
    {
        public Pawn(Player player) 
            : base(player) { }
        
        

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            List<Square> availableMoves = new List<Square>();
            Square pieceLocation = board.FindPiece(this);
            const int white = -1;
            const int black = 1;

            if (this.Player == Player.Black)
            {
                //availableMoves.AddRange(AddForwardOptions(pieceLocation, availableMoves, white));
                Square oneSquareForward = new Square(pieceLocation.Row + 1, pieceLocation.Col);
                Square twoSquaresForward = new Square(pieceLocation.Row + 2, pieceLocation.Col);
                availableMoves.Add(oneSquareForward);
                if (!HasMoved)
                {
                    availableMoves.Add(twoSquaresForward);
                }
            }
            else if (this.Player == Player.White)
            {
                //availableMoves.AddRange(AddForwardOptions(pieceLocation, availableMoves, black));
                Square oneSquareForward = new Square(pieceLocation.Row -1, pieceLocation.Col);
                Square twoSquaresForward = new Square(pieceLocation.Row -2 , pieceLocation.Col);
                availableMoves.Add(oneSquareForward);
                if (!HasMoved)
                {
                    availableMoves.Add(twoSquaresForward);
                }
            }
            return availableMoves;
        }

        private IEnumerable<Square> AddForwardOptions(Square pieceLocation, List<Square> availableMoves, int whiteOrBlack)
        {
            Square oneSquareForward = new Square(pieceLocation.Row + (1*whiteOrBlack), pieceLocation.Col);
            Square twoSquaresForward = new Square(pieceLocation.Row + (2*whiteOrBlack), pieceLocation.Col);
            availableMoves.Add(oneSquareForward);
            if (!HasMoved)
            {
                availableMoves.Add(twoSquaresForward);
            }
            return availableMoves;
        }
        
        
        
    }
}