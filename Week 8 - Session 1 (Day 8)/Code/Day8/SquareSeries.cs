using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    internal class SquareSeries : IShapeSeries
    {

        private int _side = 0;

        public int CurrentShapeArea { get ; set; }


        public void GetNextArea()
        {
            _side++;
            CurrentShapeArea = _side * _side;
        }

        public void ResetSeries()
        {
            _side = 0;
            CurrentShapeArea = 0;
        }

        override public string ToString()
        {
            return $"Square with side {_side} has area {CurrentShapeArea}";
        }
    }
}
