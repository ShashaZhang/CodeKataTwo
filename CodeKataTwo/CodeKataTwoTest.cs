using Xunit;

namespace CodeKataTwo
{
    public class CodeKataTwoTest
    {
        [Fact]
        public void shouldReturnMinusOneWhenArrayIsEmpty()
        {
            SortTool sortTool = new SortTool();
            int[] array = new int[]{};

            int position = sortTool.chop(3, array);

            Assert.Equal( -1 ,  position );
        }

        [Fact]
        public void shouldReturnMinusOneWhenElementNotInArray()
        {
            SortTool sortTool = new SortTool();
            int[] array = new int[]{1};

            int position = sortTool.chop(3, array);

            Assert.Equal(-1, position);
        }

        [Fact]
        public void shouldReturnZeroWhenElmentInTheFirstPlaceOfTheArray()
        {
            SortTool sortTool = new SortTool();
            int[] array = new int[]{1};

            int position = sortTool.chop(1, array);

            Assert.Equal(0, position);
        }

        [Fact]
        public void shouldReturnElementPosition()
        {
            SortTool sortTool = new SortTool();
            int[] array = new int[] {1, 3, 5};

            Assert.Equal(0, sortTool.chop(1, array) );
            Assert.Equal(1, sortTool.chop(3, array) );
            Assert.Equal(2, sortTool.chop(5, array) );
        }
    }
}
