﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OthelloCS
{
    /* マス */
    public class Square
    {
        private Disc _disc;

        public Square()
        {
        }

        public Disc MyDisc
        {
            get { return _disc; }
            set { _disc = value; }
        }

        /* 設置する */
        public void PutDisc(Disc disc)
        {
            _disc = disc;
        }

        /* 石ある? */
        public bool IsExistDisc()
        {
            if (_disc == null)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }

}
