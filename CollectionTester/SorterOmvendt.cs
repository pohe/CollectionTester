﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionTester
{
    class SorterOmvendt : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            if (y > x)
                return 1;
            else if (x > y)
                return -1;
            else
            {
                return 0;
            }
        }
    }
}
