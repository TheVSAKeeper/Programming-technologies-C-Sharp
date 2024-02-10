namespace Sorting.ArraysSorters
{
    internal class QuickSort : ArraySorter
    {
        public override Sorting Type => Sorting.Быстрая;

        public override void Sort(int[] array)
        {
            QuickSortHoara(array, 0, array.Length - 1);
        }

        private void QuickSortHoara(int[] arr, int start, int end)
        {
            if (start >= end)
                return;

            int rightStart = PartOfSortHoara(arr, start, end);
            QuickSortHoara(arr, start, rightStart - 1);
            QuickSortHoara(arr, rightStart, end);
        }

        private int PartOfSortHoara1(int[] arr, int left, int right)
        {
            int pivot = arr[(left + right) / 2];

            while (Compare(left, right) <= 0)
            {
                while (Compare(arr[left], pivot) < 0)
                    left++;

                while (Compare(arr[right], pivot) > 0)
                    right--;

                if (Compare(left, right) <= 0)
                {
                    Exchange(ref arr[left], ref arr[right]);
                    left++;
                    right--;
                }
            }

            return left;
        }

        private int PartOfSortHoara(int[] arr, int left, int right)
        {
            int pivot = arr[(left + right) / 2];

            while (left <= right)
            {
                while (Compare(arr[left], pivot) < 0)
                    left++;

                while (Compare(arr[right], pivot) > 0)
                    right--;

                if (left <= right)
                {
                    Exchange(ref arr[left], ref arr[right]);
                    left++;
                    right--;
                }
            }

            return left;
        }
    }
}