namespace Sorting.ArraysSorters
{
    internal class SelectionSort : ArraySorter
    {
        public override Sorting Type => Sorting.Выбором;

        public override void Sort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < array.Length; j++)
                    if (Compare(array[j], array[minIndex]) < 0)
                        minIndex = j;

                if (Compare(minIndex, i) != 0)
                    Exchange(ref array[i], ref array[minIndex]);
            }
        }
    }
}