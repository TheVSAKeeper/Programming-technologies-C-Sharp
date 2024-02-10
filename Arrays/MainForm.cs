using System;
using System.Drawing;
using System.Windows.Forms;

namespace Arrays
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private static void Reset(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();
            dataGrid.Columns.Clear();
        }

        private static void Reset(CheckedListBox checkedList)
        {
            checkedList.TurnOn();

            for (int i = 0; i < checkedList.Items.Count; i++)
                checkedList.SetItemCheckState(i, CheckState.Unchecked);
        }

        private static void Swap(ref int x, ref int y)
        {
            (x, y) = (y, x);
        }

        private static void Fill(DataGridView grid, int[,] matrix)
        {
            if (matrix.GetLength(0) <= 0 || matrix.GetLength(1) <= 0)
                return;

            int requiredRowCount = matrix.GetLength(0);
            int requiredColumnCount = matrix.GetLength(1);

            grid.RowCount = requiredRowCount;
            grid.ColumnCount = requiredColumnCount;

            for (int i = 0; i < requiredRowCount; i++)
                for (int j = 0; j < requiredColumnCount; j++)
                    grid[j, i].Value = matrix[i, j];

            grid.AutoResizeRows();
            grid.AutoResizeColumns();
        }

        private bool TryGetUserMatrix(out int[,] matrix)
        {
            int minValue = (int)_minMatrixValue.Value;
            int maxValue = (int)_maxMatrixValue.Value;
            int dimensionOfMatrix = (int)_dimensionOfMatrix.Value;
            matrix = null;

            if (maxValue < minValue)
            {
                _matrixInformation.Text = @"Макс значение не м.б. меньше мин значения!";
                return false;
            }

            matrix = GenerateWithRandomNumbers(dimensionOfMatrix, minValue, maxValue + 1);
            return true;
        }

        private static int[,] GenerateWithRandomNumbers(int dimensionOfMatrix, int minValue, int maxValue)
        {
            Random random = new Random();
            int[,] matrix = new int[dimensionOfMatrix, dimensionOfMatrix];

            for (int i = 0; i < dimensionOfMatrix; i++)
                for (int j = 0; j < dimensionOfMatrix; j++)
                    matrix[i, j] = random.Next(minValue, maxValue);

            return matrix;
        }

        private static int[,] ResizeMatrix(int[,] matrix, int newRowCount, int newColumnCount)
        {
            if (newRowCount < 0 || newColumnCount < 0)
                throw new AggregateException("Incorrect new size");

            int[,] temp = new int[newRowCount, newColumnCount];

            for (int i = 0; i < newRowCount && i < matrix.GetLength(0); i++)
                for (int j = 0; j < newColumnCount && j < matrix.GetLength(1); j++)
                    temp[i, j] = matrix[i, j];

            return temp;
        }

        private static void Highlight(DataGridView dataGrid, Func<int, int, bool> predicate, Color backColor)
        {
            for (int i = 0; i < dataGrid.RowCount; i++)
                for (int j = 0; j < dataGrid.ColumnCount; j++)
                    if (predicate(i, j))
                        dataGrid[j, i].Style.BackColor = backColor;
        }
    }
}