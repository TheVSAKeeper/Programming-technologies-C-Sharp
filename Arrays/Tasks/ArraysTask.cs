using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Arrays
{
    partial class MainForm
    {
        private void OnArraysStartClicked(object sender, EventArgs e)
        {
            _arraysStartButton.TurnOff();
            _arrayInformation.ResetText();

            int minValue = (int)_minArrayValue.Value;
            int maxValue = (int)_maxArrayValue.Value;

            if (maxValue < minValue)
            {
                _arrayInformation.Text = @"Макс значение не м.б. меньше мин значения!";
                return;
            }

            int startArrayLength = (int)_startArrayLength.Value;
            int endArrayLength = (int)_endArrayLength.Value;
            int lengthChangeStep = (int)_lengthChangeStep.Value;

            if (startArrayLength > endArrayLength)
                return;

            _testsProgress.Maximum = endArrayLength - startArrayLength;
            _testsProgress.Step = lengthChangeStep;

            for (int i = startArrayLength; i <= endArrayLength; i += lengthChangeStep)
            {
                int[] array = new int[i];
                FillWithRandomNumbers(array, minValue, maxValue + 1);

                if (_drawTableCheckBox.Checked)
                    AddArrayToTable(array, $"Исходный массив ({array.Length})");

                _arrayInformation.Text = PerformTask(array);
                _testsProgress.PerformStep();
            }
        }

        private void OnArraysResetClicked(object sender, EventArgs e)
        {
            _chartOfNumberOfComparisons.Series[0].Points.Clear();
            _chartOfNumberOfExchanges.Series[0].Points.Clear();

            Reset(_arraysTable);

            _arrayInformation.ResetText();
            _arraysStartButton.TurnOn();
        }

        private void AddArrayToTable(int[] testNumbers, string name)
        {
            int numberOfColumns = testNumbers.Length + 1;

            if (_arraysTable.ColumnCount < numberOfColumns)
                _arraysTable.ColumnCount = numberOfColumns;

            _arraysTable.AutoResizeColumns();

            if (_arraysTable.RowCount % 3 == 0)
                _arraysTable.Rows.Add();

            _arraysTable.Rows.Add();

            int rowIndex = _arraysTable.RowCount - 2;
            DataGridViewRow row = _arraysTable.Rows[rowIndex];

            row.Cells[0].Value = name;

            for (int i = 1; i < numberOfColumns; i++)
                row.Cells[i].Value = testNumbers[i - 1];
        }

        private string PerformTask(int[] array)
        {
            int numberOfComparisons = array.Length;
            int numberOfExchanges = 0;

            array = RemoveAll(array, 0);

            if (array.Length == 0)
                return "В массиве одни нули";

            Sort(array, ref numberOfComparisons, ref numberOfExchanges);

            if (_drawTableCheckBox.Checked)
                AddArrayToTable(array, $"Получен массив ({array.Length})");

            if (_drawGraphicCheckBox.Checked)
            {
                AddPoint(_chartOfNumberOfComparisons, "Кол-во сравнений", array.Length, numberOfComparisons);
                AddPoint(_chartOfNumberOfExchanges, "Кол-во замен", array.Length, numberOfExchanges);
            }

            return $"Количество сравнений = {numberOfComparisons}\nКоличество обменов = {numberOfExchanges}";
        }

        private static void AddPoint(Chart chart, string name, int x, int y)
        {
            chart.Series[0].Name = name;
            chart.Series[0].Points.AddXY(x, y);
        }

        private static void FillWithRandomNumbers(int[] numbers, int minValue, int maxValue)
        {
            Random random = new Random();

            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = random.Next(minValue, maxValue);
        }

        private static int[] RemoveAll(int[] numbers, int removedNumber)
        {
            int shift = 0;
            int[] tempArray = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
                if (numbers[i] == removedNumber)
                    shift++;
                else
                    tempArray[i - shift] = numbers[i];

            Array.Resize(ref tempArray, tempArray.Length - shift);

            return tempArray;
        }

        private static void Sort(int[] array, ref int numberOfComparisons, ref int numberOfExchanges)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > 0 & array[j] > 0 & array[i] < array[j])
                    {
                        Swap(ref array[i], ref array[j]);
                        numberOfExchanges++;
                    }

                    numberOfComparisons += 3;

                    if (array[i] < 0 & array[j] < 0 & array[i] > array[j])
                    {
                        Swap(ref array[i], ref array[j]);
                        numberOfExchanges++;
                    }

                    numberOfComparisons += 3;
                }
            }
        }
    }
}