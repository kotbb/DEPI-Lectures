using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    static class Helper2<T> where T : IComparable<T>
    {
        public static void Swap(ref T X, ref T Y)
        {
            T Temp = X;
            X = Y;
            Y = Temp;
        }
        public static int SearchArr(T[] Arr, T Value)
        {
            for (int i = 0; i < Arr?.Length; i++)
            {
                if (Value.Equals((Arr[i])))
                    return i;
            }
            return -1;
        }

        public static T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

        public static void ReplaceArray(T[] Arr, T OldValue, T NewValue)
        {
            for (int i = 0; i < Arr?.Length; i++)
            {
                if (Arr[i].Equals((OldValue)))
                    Arr[i] = NewValue;
            }
        }
    }
}
