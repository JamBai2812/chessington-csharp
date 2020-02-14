﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public abstract class Piece
    {
        public int CaptureValue { get; set; }
        //Constructors
        protected Piece(Player player, int captureValue)
        {
            Player = player;
            CaptureValue = captureValue;
        }
        protected bool HasMoved { get; set; }

        public Player Player { get; private set; }

        public abstract IEnumerable<Square> GetAvailableMoves(Board board);

        public void MoveTo(Board board, Square newSquare)
        {
            var currentSquare = board.FindPiece(this);
            board.MovePiece(currentSquare, newSquare);
            HasMoved = true;
        }
    }
}