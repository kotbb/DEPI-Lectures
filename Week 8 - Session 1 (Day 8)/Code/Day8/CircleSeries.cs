using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    internal class CircleSeries : IShapeSeries
    {

        private int _radius = 0;

        public int CurrentShapeArea { get; set; }

        public void GetNextArea()
        {
            _radius++;
            CurrentShapeArea = (int)(_radius * _radius * Math.PI);
        }

        public void ResetSeries()
        {
            _radius = 0;
            CurrentShapeArea = 0;
        }

        override public string ToString()
        {
            return $"Circle with radius {_radius} has area {CurrentShapeArea}";
        }
    }
}
