using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Sorting
{
    public partial class ComparisonForm : Form
    {
        public ComparisonForm()
        {
            InitializeComponent();
        }

        public void Show(IReadOnlyList<SortRecord> firstRecords, IReadOnlyList<SortRecord> secondRecords)
        {
            Chart chart = CreateJoinedChart(firstRecords, secondRecords);

            Sorting firstSorting = firstRecords.First().Type;
            Sorting secondSorting = secondRecords.First().Type;

            Text = $@"Сравнение сортировки {firstSorting} и сортировки {secondSorting}";

            Chart comparisons = CrateChart("сравнений", firstRecords, firstSorting, secondSorting);
            Chart exchanges = CrateChart("обменов", secondRecords, firstSorting, secondSorting);

            FillSeries(firstRecords, comparisons.Series[0], exchanges.Series[0]);
            FillSeries(secondRecords, comparisons.Series[1], exchanges.Series[1]);

            _chartsTable.Controls.Add(comparisons);
            _chartsTable.Controls.Add(chart);
            _chartsTable.Controls.Add(exchanges);

            FillGrids(firstRecords, secondRecords);

            ShowPerformanceComparison(firstRecords, secondRecords);

            _comparisonCountGrid.Rows.HighlightMin(Color.GreenYellow);
            _exchangeCountGrid.Rows.HighlightMin(Color.GreenYellow);

            Show();
        }

        private void ShowPerformanceComparison(IReadOnlyList<SortRecord> firstRecords, IReadOnlyList<SortRecord> secondRecords)
        {
            GetSum(firstRecords, out int firstComparisonCount, out int firstExchangeCount);
            GetSum(secondRecords, out int secondComparisonCount, out int secondExchangeCount);

            string firstSortingName = firstRecords.First().Type.ToString();
            string secondSortingName = secondRecords.First().Type.ToString();
            SetBest(firstComparisonCount, secondComparisonCount, firstSortingName, secondSortingName, textBox1);
            SetBest(firstExchangeCount, secondExchangeCount, firstSortingName, secondSortingName, textBox2);
        }

        private static void SetBest(int firstCount, int secondCount, string firstName, string secondName, Control control)
        {
            string best;
            string worst;

            if (firstCount < secondCount)
            {
                best = firstName;
                worst = secondName;
            }
            else
            {
                best = secondName;
                worst = firstName;
            }

            float percent = Math.Abs(firstCount - secondCount) / (float)(firstCount + secondCount) * 100;
            control.Text = $@"Сортировка {best} эффективнее сортировки {worst} на {Math.Round(percent, 2)}%";
        }

        private static void GetSum(IEnumerable<SortRecord> records, out int comparisonCount, out int exchangeCount)
        {
            comparisonCount = 0;
            exchangeCount = 0;

            foreach (SortRecord record in records)
            {
                comparisonCount += record.ComparisonsCount;
                exchangeCount += record.ExchangeCount;
            }
        }

        private void FillGrids(IReadOnlyList<SortRecord> firstRecords, IReadOnlyList<SortRecord> secondRecords)
        {
            _comparisonCountGrid.Columns.Add(firstRecords.First().Type.ToString());
            _comparisonCountGrid.Columns.Add(secondRecords.First().Type.ToString());

            _exchangeCountGrid.Columns.Add(firstRecords.First().Type.ToString());
            _exchangeCountGrid.Columns.Add(secondRecords.First().Type.ToString());

            for (int i = 0; i < firstRecords.Count && i < secondRecords.Count; i++)
            {
                _comparisonCountGrid.Rows.Add(firstRecords[i].Length, firstRecords[i].ComparisonsCount, secondRecords[i].ComparisonsCount);
                _exchangeCountGrid.Rows.Add(firstRecords[i].Length, firstRecords[i].ExchangeCount, secondRecords[i].ExchangeCount);
            }

            _comparisonCountGrid.AutoResizeColumns();
            _exchangeCountGrid.AutoResizeColumns();
        }

        private static Chart CrateChart(string name, IEnumerable<SortRecord> records, Sorting firstSorting, Sorting secondSorting)
        {
            Chart chart = new ArraySorterChart(records.First().Type).Chart;

            chart.Titles[0] = new Title($"График кол-ва {name}");

            chart.Series[0].Name = $"{firstSorting}";
            chart.Series[1].Name = $"{secondSorting}";

            return chart;
        }

        private static Chart CreateJoinedChart(IReadOnlyList<SortRecord> firstRecords, IReadOnlyList<SortRecord> secondRecords)
        {
            const int BorderWidth = 2;

            Sorting firstSorting = firstRecords.First().Type;
            Sorting secondSorting = secondRecords.First().Type;

            Series firstChartComparisons = new Series
            {
                BorderWidth = BorderWidth,
                ChartType = SeriesChartType.Spline,
                Color = Color.Red,
                Name = $"Сравнения {firstSorting}"
            };

            Series firstChartExchanges = new Series
            {
                BorderWidth = BorderWidth,
                ChartType = SeriesChartType.Spline,
                Color = Color.Blue,
                Name = $"Обмены {firstSorting}"
            };

            Series secondChartComparisons = new Series
            {
                BorderWidth = BorderWidth,
                ChartType = SeriesChartType.Spline,
                Color = Color.Orange,
                Name = $"Сравнения {secondSorting}"
            };

            Series secondChartExchanges = new Series
            {
                BorderWidth = BorderWidth,
                ChartType = SeriesChartType.Spline,
                Color = Color.Green,
                Name = $"Обмены {secondSorting}"
            };

            FillSeries(firstRecords, firstChartComparisons, firstChartExchanges);
            FillSeries(secondRecords, secondChartComparisons, secondChartExchanges);

            string chartName = $"График сравнения сортировки {firstSorting} и сортировки {secondSorting}";
            Chart chart = new Chart { Dock = DockStyle.Fill, Name = chartName, Titles = { new Title(chartName, Docking.Top) } };

            chart.ChartAreas.Add(new ChartArea { AxisX = { Title = "Размер массива" }, AxisY = { Title = "Количество" } });
            chart.Legends.Add(new Legend());

            chart.Series.Add(firstChartComparisons);
            chart.Series.Add(firstChartExchanges);

            chart.Series.Add(secondChartComparisons);
            chart.Series.Add(secondChartExchanges);

            chart.AddSaveAsMenuItem();
            chart.AddChangeTypeMenuItem();

            return chart;
        }

        private static void FillSeries(IEnumerable<SortRecord> records, Series comparisons, Series exchanges)
        {
            foreach (SortRecord record in records)
            {
                comparisons.Points.Add(record.GetComparisonsPoint());
                exchanges.Points.Add(record.GetExchangePoint());
            }
        }
    }
}