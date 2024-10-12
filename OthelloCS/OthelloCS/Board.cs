using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OthelloCS
{
    public class Board
    {
        /* ボード */
        /* Singleton にする */
        private Square[,] _square;

        public Board()
        {
            _square = new Square[8, 8]
            {
                { new Square(), new Square(), new Square(),new Square(), new Square(), new Square(),new Square(), new Square() },
                { new Square(), new Square(), new Square(),new Square(), new Square(), new Square(),new Square(), new Square() },
                { new Square(), new Square(), new Square(),new Square(), new Square(), new Square(),new Square(), new Square() },
                { new Square(), new Square(), new Square(),new Square(), new Square(), new Square(),new Square(), new Square() },
                { new Square(), new Square(), new Square(),new Square(), new Square(), new Square(),new Square(), new Square() },
                { new Square(), new Square(), new Square(),new Square(), new Square(), new Square(),new Square(), new Square() },
                { new Square(), new Square(), new Square(),new Square(), new Square(), new Square(),new Square(), new Square() },
                { new Square(), new Square(), new Square(),new Square(), new Square(), new Square(),new Square(), new Square() }
            };
        }

        /* 配置する */
        public void PlaceSquare(Color discColor,int row ,int column)
        {
            /* 石ここで持ったらだめくね？ */
            /* Disc disc = new Disc(discColor); */

            _square[row, column].PutDisc(discColor);
        }
    }
}
