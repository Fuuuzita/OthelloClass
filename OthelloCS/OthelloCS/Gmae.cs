using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OthelloCS
{
    /* ゲーム */
    public class Gmae
    {
        private Board _board;
        private Player _player1;
        private Player _player2;

        void BoardInit()
        {
            _board = new Board();
            _player1 = new Player(Color.Black);
            _player2 = new Player(Color.White);

            /* ボードの初期配置 */
            _board.PlaceSquare(Color.Black, 3, 3);
            _board.PlaceSquare(Color.White, 3, 4);
            _board.PlaceSquare(Color.White, 4, 3);
            _board.PlaceSquare(Color.Black, 4, 4);
        }

    }
}
