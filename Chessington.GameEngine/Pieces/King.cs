using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class King : Piece
    {
        public King(Player player)
            : base(player, 100) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            return Enumerable.Empty<Square>();
        }
    }
}