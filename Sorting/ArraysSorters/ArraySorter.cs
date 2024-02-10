using System;

namespace Sorting.ArraysSorters
{
    internal abstract class ArraySorter
    {
        public abstract Sorting Type { get; }
        public event Action ElementsExchanged;
        public event Action ElementsCompared;

        public abstract void Sort(int[] array);

        protected void Exchange(ref int firstElement, ref int secondElement)
        {
            (firstElement, secondElement) = (secondElement, firstElement);
            ElementsExchanged?.Invoke();
        }

        protected int Compare(int number, int value)
        {
            int result = number.CompareTo(value);
            ElementsCompared?.Invoke();
            return result;
        }
    }
}