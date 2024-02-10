using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sorting.ArraysSorters;

namespace Sorting
{
    public partial class MainForm : Form
    {
        private readonly Dictionary<TestModule, TabPage> _availableSortingTests;

        public MainForm()
        {
            _availableSortingTests = new Dictionary<TestModule, TabPage>
            {
                { new TestModule(new BubbleSort()), null },
                { new TestModule(new BubbleSortRecursive()), null },
                { new TestModule(new SelectionSort()), null },
                { new TestModule(new InsertionSort()), null },
                { new TestModule(new InsertionSortRecursive()), null },
                { new TestModule(new Shellsort()), null },
                { new TestModule(new QuickSort()), null }
            };

            InitializeComponent();
            AddSortingSelectionMenu();

            SortingSelected += OnSortingSelected;
            SortingUnselected += OnSortingUnselected;
        }

        private IEnumerable<TestModule> SelectedTests => _availableSortingTests.Where(x => x.Value != null).Select(x => x.Key);

        private event Action<TestModule> SortingSelected;
        private event Action<TestModule> SortingUnselected;

        private void OnStartClicked(object sender, EventArgs e)
        {
            _start.TurnOff();
            _sortsSelector.TurnOff();
            _compareCharts.TurnOn();

            if (SelectedTests.Any() == false)
            {
                Debug("Сортировки не выбраны!");
                return;
            }

            int startLength = (int)_startArrayLength.Value;
            int endLength = (int)_endArrayLength.Value;
            int step = (int)_arrayLengthChangeStep.Value;

            if (endLength < startLength)
            {
                Debug(@"Конечная длина не м.б. меньше начальной длины!");
                return;
            }

            int minValue = (int)_minArrayElement.Value;
            int maxValue = (int)_maxArrayElement.Value;

            if (maxValue < minValue)
            {
                Debug(@"Макс значение не м.б. меньше мин значения!");
                return;
            }

            List<int> testLengths = GetArrayTestLengths(startLength, endLength, step);

            AddToGrid(_comparisonCountGrid, 0, testLengths);
            AddToGrid(_exchangeCountGrid, 0, testLengths);

            StringBuilder information = new StringBuilder();

            _progressBar.Maximum = endLength - startLength;
            _progressBar.Step = step;

            foreach (int[] array in testLengths.Select(length => CreateRandomArray(length, minValue, maxValue)))
            {
                information.AppendLine($"Исходный массив ({array.Length})");
                information.AppendLine($"{string.Join(" ", array)}");

                MakeTests(SelectedTests, array, information);

                _progressBar.PerformStep();
            }

            _arraysDescription.Text = information.ToString();

            FillGrid(SelectedTests, _comparisonCountGrid, _exchangeCountGrid);
        }

        private void OnClearFormClicked(object sender, EventArgs e)
        {
            _comparisonCountGrid.Rows.Clear();
            _exchangeCountGrid.Rows.Clear();

            _error.ResetText();
            _arraysDescription.ResetText();

            _start.TurnOn();
            _sortsSelector.TurnOn();
            _compareCharts.TurnOff();

            _progressBar.Value = _progressBar.Minimum;

            foreach (TestModule testModule in SelectedTests)
                testModule.Clear();
        }

        private void OnSaveAllChartsClicked(object sender, EventArgs e)
        {
            foreach (TestModule test in SelectedTests)
                test.SaveChart();
        }

        private void OnHelpClicked(object sender, EventArgs e)
        {
            HelpForm help = new HelpForm();
            help.ShowDialog();
        }

        private void OnCloseClicked(object sender, EventArgs e)
        {
            Close();
        }

        private void OnSortingSelected(TestModule testModule)
        {
            string newSortingName = testModule.Type.ToString();
            TabPage sortingPage = new TabPage { Text = $@"Графики ({testModule.Type})", Name = newSortingName };

            sortingPage.Controls.Add(testModule.Chart);
            _tabControl.Controls.Add(sortingPage);

            _availableSortingTests[testModule] = sortingPage;

            _comparisonCountGrid.Columns.Add(newSortingName, newSortingName);
            _exchangeCountGrid.Columns.Add(newSortingName, newSortingName);

            AddCompareMenuItem(newSortingName);

            _sortsSelector.ShowDropDown();
        }

        private void OnSortingUnselected(TestModule testModule)
        {
            string name = testModule.Type.ToString();

            _tabControl.Controls.Remove(_availableSortingTests[testModule]);

            _availableSortingTests[testModule] = null;

            _comparisonCountGrid.Columns.Remove(name);
            _exchangeCountGrid.Columns.Remove(name);

            _compareCharts.DropDownItems.RemoveByKey(name);

            foreach (ToolStripMenuItem item in _compareCharts.DropDownItems)
                item.DropDownItems.RemoveByKey(name);

            _sortsSelector.ShowDropDown();
        }

        private void AddCompareMenuItem(string newSortingName)
        {
            ToolStripMenuItem rootMenu = new ToolStripMenuItem(newSortingName) { Name = newSortingName };

            for (int i = 0; i < _compareCharts.DropDownItems.Count; i++)
            {
                ToolStripMenuItem otherSorting = (ToolStripMenuItem)_compareCharts.DropDownItems[i];

                ToolStripMenuItem sorting = new ToolStripMenuItem(newSortingName) { Name = otherSorting.Text, Text = otherSorting.Text };
                ToolStripMenuItem otherSortingItem = new ToolStripMenuItem(newSortingName) { Name = newSortingName, Text = newSortingName };

                rootMenu.DropDownItems.Add(sorting);
                otherSorting.DropDownItems.Add(otherSortingItem);
            }

            rootMenu.DropDownItemClicked += OnCompareSortsClicked;
            _compareCharts.DropDownItems.Add(rootMenu);
        }

        private void OnCompareSortsClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripMenuItem clickedMenuItem = (ToolStripMenuItem)e.ClickedItem;

            SortRecord[] firstRecords = SelectedTests.First(x => x.Type.ToString() == clickedMenuItem.Text).Records.ToArray();
            SortRecord[] secondRecords = SelectedTests.First(x => x.Type.ToString() == clickedMenuItem.OwnerItem.Text).Records.ToArray();

            ComparisonForm comparisonForm = new ComparisonForm();
            comparisonForm.Show(firstRecords, secondRecords);
        }

        private void AddSortingSelectionMenu()
        {
            foreach (TestModule sorter in _availableSortingTests.Keys)
            {
                ToolStripMenuItem item = new ToolStripMenuItem(sorter.Type.ToString());
                item.CheckOnClick = true;

                item.CheckedChanged += (sender, args) =>
                {
                    if (item.Checked)
                        SortingSelected?.Invoke(sorter);
                    else
                        SortingUnselected?.Invoke(sorter);
                };

                _sortsSelector.DropDownItems.Add(item);
            }
        }

        private static void MakeTests(IEnumerable<TestModule> selectedTests, int[] array, StringBuilder information)
        {
            foreach (TestModule testModule in selectedTests)
            {
                int[] testArray = testModule.Test(array);

                information.AppendLine($"Сортировка {testModule.Type}");
                information.AppendLine($"{string.Join(" ", testArray)}");
            }
        }

        private void Debug(string message)
        {
            _error.Text = message;
        }

        private static void FillGrid(IEnumerable<TestModule> tests, DataGridView comparisonCountGrid, DataGridView exchangeCountGrid)
        {
            foreach (TestModule test in tests)
            {
                int row = 0;

                foreach (SortRecord record in test.Records)
                {
                    string columnName = test.Type.ToString();
                    comparisonCountGrid[columnName, row].Value = record.ComparisonsCount;
                    exchangeCountGrid[columnName, row].Value = record.ExchangeCount;
                    row++;
                }
            }
        }

        private static int[] CreateRandomArray(int length, int minValue, int maxValue)
        {
            Random random = new Random();
            int[] array = new int[length];

            for (int i = 0; i < array.Length; i++)
                array[i] = random.Next(minValue, maxValue + 1);

            return array;
        }

        private static List<int> GetArrayTestLengths(int startLength, int endLength, int step)
        {
            List<int> testLengths = new List<int>();

            for (int i = startLength; i <= endLength; i += step)
                testLengths.Add(i);

            return testLengths;
        }

        private static void AddToGrid(DataGridView dataGridView, int column, IEnumerable<int> elements)
        {
            foreach (int element in elements)
                dataGridView[column, dataGridView.RowCount++].Value = element;
        }
    }
}