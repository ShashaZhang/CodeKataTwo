namespace CodeKataTwo
{
    public class SortTool
    {
        public int chop(int goalValue, int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == goalValue)
                    return i;
            }
                return -1;
        }
    }
}