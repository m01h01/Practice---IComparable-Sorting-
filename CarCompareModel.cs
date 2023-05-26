﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice___IComparable___Sorting__
{
    internal class CarCompareModel : IComparer<Car>
    {
        public int Compare(Car? x, Car? y)
        {
            return x.Model.CompareTo(y.Model);
        }
    }
}
