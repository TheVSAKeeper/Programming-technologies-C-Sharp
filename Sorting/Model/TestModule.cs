using System;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;
using Sorting.ArraysSorters;

namespace Sorting
{
    internal class TestModule
    {
        private readonly ArraySorter _sorting;
        private readonly ArraySorterChart _chart;
        private readonly List<SortRecord> _records;

        public TestModule(ArraySorter sorting)
        {
            _sorting = sorting;
            _chart = new ArraySorterChart(sorting.Type);
            _records = new List<SortRecord>();

            RecordAdded += _chart.AddRecord;
        }

        public IEnumerable<SortRecord> Records => _records;
        public Chart Chart => _chart.Chart;
        public Sorting Type => _sorting.Type;

        private event Action<SortRecord> RecordAdded;

        public void SaveChart()
        {
            _chart.SaveChart();
        }

        public int[] Test(int[] array)
        {
            int exchangeCount = 0;
            int comparisonsCount = 0;

            _sorting.ElementsExchanged += () => exchangeCount++;
            _sorting.ElementsCompared += () => comparisonsCount++;

            int[] testArray = (int[])array.Clone();
            _sorting.Sort(testArray);

            SortRecord record = new SortRecord(array.Length, exchangeCount, comparisonsCount, Type);
            _records.Add(record);
            RecordAdded?.Invoke(record);

            return testArray;
        }

        public void Clear()
        {
            _chart.Clear();
            _chart.Clear();
            _records.Clear();
        }
    }
}