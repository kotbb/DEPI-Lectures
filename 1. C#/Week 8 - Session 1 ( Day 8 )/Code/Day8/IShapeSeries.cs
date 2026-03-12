using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    internal interface IShapeSeries
    {

        public int CurrentShapeArea { get; set; }

        public void GetNextArea();
        public void ResetSeries();

    }
}
