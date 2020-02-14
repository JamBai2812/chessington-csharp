﻿using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Pawn : Piece
    {
        public Pawn(Player player) 
            : base(player) { }
        
        public bool HasMoved { get; set; }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            List<Square> availableMoves = new List<Square>();
            Square pieceLocation = board.FindPiece(this);
            HasMoved = false;
            
            if (this.Player == Player.Black)
            {
                Square oneSquareDown = new Square(pieceLocation.Row+1,pieceLocation.Col );
                availableMoves.Add(oneSquareDown);
            }
            else if (this.Player == Player.White)
            {
                Square oneSquareUp = new Square(pieceLocation.Row-1,pieceLocation.Col);
                availableMoves.Add(oneSquareUp);
            }
            return availableMoves;
        }
        
        
        
        
    }
}