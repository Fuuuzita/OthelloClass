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
        Dictionary<Tuple<string, int> ,Square> board = new Dictionary<Tuple<string, int>, Square>();

        public Board()
        {
            string[] colum= new string[] {"A","B","C","D","E","F","G","H" };
            int[] row = new int[] {1,2,3,4,5,6,7,8};

            for(int i = 0;i<8; i++)
            {
                for(int j = 0;j<8; j++)
                {
                    board.Add(new Tuple<string, int>(colum[i], row[j]), new Square());
                }
            }
        }

        /* 配置する */
        public void PlaceSquare(Color discColor,int row ,int column)
        {
            Disc disc = new Disc(discColor);

            _square[row, column].PutDisc(disc);
        }
    }
}
