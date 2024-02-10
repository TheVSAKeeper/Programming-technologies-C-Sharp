namespace Sorting.ArraysSorters
{
    internal class BubbleSort : ArraySorter
    {
        public override Sorting Type => Sorting.Пузырьком;

        public override void Sort(int[] array)
        {
            for (int i = array.Length - 1; i > 0; i--)
                for (int j = 1; j <= i; j++)
                    if (Compare(array[j - 1], array[j]) > 0)
                        Exchange(ref array[j - 1], ref array[j]);
        }
    }
}