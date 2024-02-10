using System.Windows.Forms.DataVisualization.Charting;

namespace Sorting
{
    public readonly struct SortRecord
    {
        public Sorting Type { get; }
        public int Length { get; }
        public int ExchangeCount { get; }
        public int ComparisonsCount { get; }

        public SortRecord(int length, int exchangeCount, int comparisonsCount, Sorting type)
        {
            Length = length;
            ExchangeCount = exchangeCount;
            ComparisonsCount = comparisonsCount;
            Type = type;
        }

        public DataPoint GetExchangePoint() => new DataPoint(Length, ExchangeCount);
        public DataPoint GetComparisonsPoint() => new DataPoint(Length, ComparisonsCount);
    }
}