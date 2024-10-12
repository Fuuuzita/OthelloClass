using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OthelloCS
{
    /* プレイヤー */
    public class Player
    {
        private Color _color;

        public Player(Color myColor) 
        {
            _color = myColor;
        }

        /* 石をおく */
        public void PutDisc(int row, int column)
        {
            Board board = new Board();

            board.PlaceSquare(_color, row, column);
        }
    }
}
