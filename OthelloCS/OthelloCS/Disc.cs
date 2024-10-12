using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OthelloCS
{
    /* 石 */
    public class Disc
    {
        private Color _color;

        public Disc(Color myColor)
        {
            _color = myColor;
        }

        public Color MyColor
        {
            get { return _color; }
            set {  _color = value; }
        }

        /* 反転する */
        public void Reverse()
        {
            if(Color.White == _color)
            {
                _color = Color.Black;
            }
            else
            {
                _color = Color.White;
            }
        }
    }

}
