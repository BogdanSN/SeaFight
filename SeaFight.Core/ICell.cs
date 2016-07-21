﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaFight.Core
{
    public interface ICell : IBombable
    {
        int X { set; get; }
        int Y { set; get; }
        bool IsShoot { set; get; }
        public IGamingObject Content { set; get; }

        public bool IsOccupied { set; get; }
    }
}
