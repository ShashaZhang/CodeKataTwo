using System;

namespace CodeKataTwo
{
    public class SortTool
    {
        public int chop(int goalValue, int[] array)
        {
            var pos = Array.BinarySearch(array, 0, array.Length, goalValue);
            return pos < 0 ? -1 : pos;
        }
    }
}