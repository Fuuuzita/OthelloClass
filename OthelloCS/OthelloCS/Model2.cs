using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
ｆｄｄ
namespace OthelloCS
{
    /* F03 */
    public class F03
    {
        private Color _color;

        public F03(Color myColor)
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
