namespace Sorting.ArraysSorters
{
    internal class Shellsort : ArraySorter
    {
        public override Sorting Type => Sorting.Шелла;

        public override void Sort(int[] array)
        {
            for (int gapSize = array.Length / 2; gapSize > 0; gapSize /= 2)
            {
                for (int currentIndex = gapSize; currentIndex < array.Length; currentIndex++)
                {
                    int currentIndexCopy = currentIndex;
                    int item = array[currentIndex];

                    while (Compare(currentIndexCopy, gapSize) >= 0 && Compare(array[currentIndexCopy - gapSize], item) > 0)
                    {
                        array[currentIndexCopy] = array[currentIndexCopy - gapSize];
                        currentIndexCopy -= gapSize;
                    }

                    array[currentIndexCopy] = item;
                }
            }
        }
    }
}