using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Sorting
{
    internal class ArraySorterChart
    {
        public ArraySorterChart(Sorting sorting)
        {
            Chart = CreateChart(sorting.ToString());
        }

        public Chart Chart { get; }

        private static Chart CreateChart(string sorter)
        {
            string chartName = $"График сортировки {sorter}";
            Title title = new Title(chartName, Docking.Top);
            Chart chart = new Chart { Dock = DockStyle.Fill, Name = chartName, Titles = { title } };
            Legend legend = new Legend { Name = $"{sorter}Legend" };

            ChartArea chartArea = new ChartArea
            {
                AxisX = { Title = "Размер массива" },
                AxisY = { Title = "Количество" },
                Name = $"{sorter}ChartArea"
            };

            Series comparisonSeries = new Series
            {
                BorderWidth = 2,
                ChartType = SeriesChartType.Spline,
                Color = Color.Red,
                Name = "Сравнения"
            };

            Series exchangeSeries = new Series
            {
                BorderWidth = 2,
                ChartType = SeriesChartType.Spline,
                Color = Color.Blue,
                Name = "Обмены"
            };

            chart.ChartAreas.Add(chartArea);
            chart.Legends.Add(legend);
            chart.Series.Add(comparisonSeries);
            chart.Series.Add(exchangeSeries);

            chart.AddSaveAsMenuItem();
            chart.AddChangeTypeMenuItem();
            return chart;
        }

        public void AddRecord(SortRecord record)
        {
            Chart.Series[0].Points.Add(record.GetComparisonsPoint());
            Chart.Series[1].Points.Add(record.GetExchangePoint());
        }

        public void Clear()
        {
            Chart.Series[0].Points.Clear();
            Chart.Series[1].Points.Clear();
        }

        public void SaveChart()
        {
            Chart.SaveChart();
        }
    }
}