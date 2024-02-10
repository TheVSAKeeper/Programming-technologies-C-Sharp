namespace Sorting.ArraysSorters
{
    internal class InsertionSortRecursive : ArraySorter
    {
        public override Sorting Type => Sorting.Вставками_Рекурсия;

        public override void Sort(int[] array)
        {
            Sort(array, array.Length);
        }

        private void Sort(int[] array, int length)
        {
            if (length <= 1)
                return;

            Sort(array, length - 1);

            int last = array[length - 1];
            int j = length - 2;

            while (Compare(j, 0) >= 0 && Compare(array[j], last) > 0)
            {
                array[j + 1] = array[j];
                j--;
            }

            array[j + 1] = last;
        }
    }
}