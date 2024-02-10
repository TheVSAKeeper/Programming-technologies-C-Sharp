using System;
using System.Drawing;
using System.Windows.Forms;

namespace Arrays
{
    partial class MainForm
    {
        private void OnMatrixTaskChanged(object sender, EventArgs e)
        {
            CheckedListBox list = (CheckedListBox)sender;
            string checkedItem = list.GetItemText(list.CheckedItems[0]);

            list.TurnOff();
            _matrixStartButton.TurnOn();

            switch (checkedItem)
            {
                case "Общее задание":
                    _matrixTaskLabel.Text = @"Строки с '-' на конце - удалить, а затем добавить строку из сумм по столбцам";
                    _matrixStartButton.Click += StartGeneralTask;
                    break;

                case "Индивидуальное задание":
                    _matrixTaskLabel.Text = @"Удалить строки с 0 элементами выше главной диагонали, добавить строку из разностей 1 и 2 строки";
                    _matrixStartButton.Click += StartIndividualTask;
                    break;

                default:
                    throw new NotImplementedException();
            }
        }

        private void StartIndividualTask(object sender, EventArgs e)
        {
            _matrixStartButton.TurnOff();

            if (TryGetUserMatrix(out int[,] matrix) == false)
                return;

            Fill(_initialMatrix, matrix);
            Highlight(_initialMatrix, IsAboveMainDiagonal, Color.GreenYellow);

            matrix = DeleteRow(matrix, out int deletedRowCount, _initialMatrix);
            Highlight(_initialMatrix, IsMainDiagonal, Color.Bisque);

            if (matrix.Length == 0)
            {
                _matrixInformation.Text = @"В матрице удалены все строки";
                return;
            }

            int differenceRowIndex = 2;

            if (matrix.GetLength(0) < differenceRowIndex)
            {
                _matrixInformation.Text = @"В матрице осталось меньше 2 строк";
                return;
            }

            matrix = InsertDifferenceRow(matrix, differenceRowIndex);
            Fill(_resultMatrix, matrix);
            Highlight(_resultMatrix, (i, _) => i == differenceRowIndex, Color.Gainsboro);

            _matrixInformation.Text = deletedRowCount == 0
                ? @"В матрице нет удаленных строк"
                : $@"В матрице удалено {deletedRowCount} строк(и)";
        }

        private static int[,] DeleteRow(int[,] matrix, out int deletedRowCount, DataGridView matrixView)
        {
            int rowCount = matrix.GetLength(0);
            int columnCount = matrix.GetLength(1);
            int[,] tempMatrix = new int[rowCount, columnCount];

            deletedRowCount = 0;

            for (int i = 0; i < rowCount; i++)
            {
                int index = LastIndexOf(matrix, i, 0);

                if (IsAboveMainDiagonal(i, index) && index >= 0)
                {
                    int deletedRow = i;
                    Highlight(matrixView, (row, _) => row == deletedRow, Color.Red);
                    deletedRowCount++;
                }
                else
                {
                    for (int j = 0; j < columnCount; j++)
                        tempMatrix[i - deletedRowCount, j] = matrix[i, j];
                }
            }

            return ResizeMatrix(tempMatrix, rowCount - deletedRowCount, columnCount);
        }

        private static int LastIndexOf(int[,] matrix, int row, int number)
        {
            for (int j = matrix.GetLength(1) - 1; j >= 0; j--)
                if (matrix[row, j] == number)
                    return j;

            return -1;
        }

        private static int[,] InsertDifferenceRow(int[,] matrix, int row)
        {
            int rowCount = matrix.GetLength(0);
            int columnCount = matrix.GetLength(1);
            int newRowCount = rowCount + 1;

            matrix = ResizeMatrix(matrix, newRowCount, columnCount);
            ShiftRow(matrix, row);

            for (int j = 0; j < columnCount; j++)
            {
                int differenceOfColumn = matrix[0, j] - matrix[1, j];
                matrix[row, j] = differenceOfColumn;
            }

            return matrix;
        }

        private static void ShiftRow(int[,] matrix, int row)
        {
            for (int i = matrix.GetLength(0) - 1; i > row; i--)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Swap(ref matrix[i, j], ref matrix[i - 1, j]);
        }

        private static bool IsMainDiagonal(int rowIndex, int columnIndex) => rowIndex == columnIndex;
        private static bool IsAboveMainDiagonal(int rowIndex, int columnIndex) => rowIndex < columnIndex;
    }
}