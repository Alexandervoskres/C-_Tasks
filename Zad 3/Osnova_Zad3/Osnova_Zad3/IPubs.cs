﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osnova_Zad3
{
    interface IPubs
    {
        void Subs();
        bool IfSubs { get; set; }
    }
}
