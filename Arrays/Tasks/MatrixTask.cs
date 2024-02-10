using System;
using System.Drawing;
using System.Windows.Forms;

namespace Arrays
{
    partial class MainForm
    {
        private void OnMatrixResetClicked(object sender, EventArgs e)
        {
            Reset(_initialMatrix);
            Reset(_resultMatrix);
            Reset(_tasksCheckedList);

            _matrixStartButton.Click -= StartGeneralTask;
            _matrixStartButton.Click -= StartIndividualTask;

            _matrixInformation.ResetText();
            _matrixStartButton.TurnOff();
            _matrixTaskLabel.Text = @"Выберите задание";
        }

        private void StartGeneralTask(object sender, EventArgs e)
        {
            _matrixStartButton.TurnOff();

            if (TryGetUserMatrix(out int[,] matrix) == false)
                return;

            Fill(_initialMatrix, matrix);

            matrix = DeleteRows(matrix, out int deletedRowCount, _initialMatrix);

            if (matrix.Length == 0)
            {
                _matrixInformation.Text = @"В матрице удалены все строки";
                return;
            }

            _matrixInformation.Text = deletedRowCount == 0
                ? @"В матрице нет удаленных строк"
                : $@"В матрице удалено {deletedRowCount} строк(и)";

            matrix = AddSumRow(matrix);
            Fill(_resultMatrix, matrix);
        }

        private static int[,] AddSumRow(int[,] matrix)
        {
            int rowCount = matrix.GetLength(0);
            int columnCount = matrix.GetLength(1);

            matrix = ResizeMatrix(matrix, rowCount + 1, columnCount);

            for (int j = 0; j < columnCount; j++)
            {
                int sumOfColumn = 0;

                for (int i = 0; i < rowCount; i++)
                    sumOfColumn += matrix[i, j];

                matrix[rowCount, j] = sumOfColumn;
            }

            return matrix;
        }

        private static int[,] DeleteRows(int[,] matrix, out int deletedRowCount, DataGridView matrixView)
        {
            int rowCount = matrix.GetLength(0);
            int columnCount = matrix.GetLength(1);
            int[,] tempMatrix = new int[rowCount, columnCount];

            deletedRowCount = 0;

            for (int i = 0; i < rowCount; i++)
                if (matrix[i, columnCount - 1] < 0)
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

            return ResizeMatrix(tempMatrix, rowCount - deletedRowCount, columnCount);
        }
    }
}