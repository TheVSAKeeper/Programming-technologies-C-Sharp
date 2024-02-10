namespace Sorting.ArraysSorters
{
    internal class InsertionSort : ArraySorter
    {
        public override Sorting Type => Sorting.Вставками;

        public override void Sort(int[] array)
        {
            int length = array.Length;

            for (int i = 1; i < length; ++i)
            {
                int element = array[i];
                int j = i - 1;

                while (Compare(j, 0) >= 0 && Compare(array[j], element) > 0)
                {
                    array[j + 1] = array[j];
                    j--;
                }

                array[j + 1] = element;
            }
        }
    }
}