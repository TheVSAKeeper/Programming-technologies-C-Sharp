namespace Sorting.ArraysSorters
{
    internal class BubbleSortRecursive : ArraySorter
    {
        public override Sorting Type => Sorting.Пузырьком_Рекурсия;

        public override void Sort(int[] array)
        {
            BubbleSort(array, array.Length);
        }

        private void BubbleSort(int[] array, int length)
        {
            if (length == 1)
                return;

            int count = 0;

            for (int i = 0; i < length - 1; i++)
            {
                if (Compare(array[i], array[i + 1]) <= 0)
                    continue;

                Exchange(ref array[i], ref array[i + 1]);
                count++;
            }

            if (count == 0)
                return;

            BubbleSort(array, length - 1);
        }
    }
}