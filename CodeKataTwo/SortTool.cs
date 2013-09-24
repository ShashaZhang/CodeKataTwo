using System;

namespace CodeKataTwo
{
    public class SortTool
    {
        public int chop(int goalValue, int[] array)
        {
            int pos = array.Length / 2;
            if (goalValue < array[pos])
            {
                while (goalValue != array[pos])
                {
                    pos--;
                }
            }else if (goalValue > array[pos])
            {
                while (goalValue != array[pos])
                {
                    pos++;
                }
            }
            else if (goalValue == array[pos])
            {
                return pos;
            }
            else
            {
                return -1;    
            }
            return pos;
        }
    }
}