using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Sorting
{
    internal static class ControlExtension
    {
        public static void TurnOn(this Control control)
        {
            control.Enabled = true;
        }

        public static void TurnOff(this Control control)
        {
            control.Enabled = false;
        }

        public static void TurnOn(this ToolStripItem control)
        {
            control.Enabled = true;
        }

        public static void TurnOff(this ToolStripItem control)
        {
            control.Enabled = false;
        }

        public static void Add(this DataGridViewColumnCollection columns, string header)
        {
            columns.Add(header, header);
        }

        public static void HighlightMin(this DataGridViewRowCollection rows, Color backColor)
        {
            foreach (DataGridViewRow row in rows)
            {
                int value = int.MaxValue;
                int index = -1;

                for (int i = 1; i < row.Cells.Count; i++)
                {
                    if ((int)row.Cells[i].Value >= value)
                        continue;

                    value = (int)row.Cells[i].Value;
                    index = i;
                }

                row.Cells[index].Style.BackColor = backColor;
            }
        }

        public static void AddSaveAsMenuItem(this Chart chart)
        {
            MenuItem saveAs = new MenuItem { Text = @"Сохранить как" };

            saveAs.Click += (sender, args) => chart.SaveChart();

            if (chart.ContextMenu != null)
                chart.ContextMenu.MenuItems.Add(saveAs);
            else
                chart.ContextMenu = new ContextMenu(new[] { saveAs });
        }

        public static void AddChangeTypeMenuItem(this Chart chart)
        {
            MenuItem[] items = Enum.GetNames(typeof(SeriesChartType))
                .Where(name => name != SeriesChartType.Kagi.ToString() &&
                               name != SeriesChartType.Renko.ToString() &&
                               name != SeriesChartType.ThreeLineBreak.ToString() &&
                               name != SeriesChartType.PointAndFigure.ToString())
                .Select(name => new MenuItem(name, OnClick))
                .ToArray();

            MenuItem selectItem = new MenuItem("Тип графика", items);

            void OnClick(object sender, EventArgs args)
            {
                MenuItem item = (MenuItem)sender;

                foreach (Series series in chart.Series)
                {
                    Enum.TryParse(item.Text, out SeriesChartType type);
                    series.ChartType = type;
                }
            }

            if (chart.ContextMenu != null)
                chart.ContextMenu.MenuItems.Add(selectItem);
            else
                chart.ContextMenu = new ContextMenu(new[] { selectItem });
        }

        public static void SaveChart(this Chart chart)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Title = @"Сохранить график как ...";
                saveFileDialog.Filter = @"*.png|*.png";
                saveFileDialog.AddExtension = true;
                saveFileDialog.FileName = $"{chart.Name}";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    chart.SaveImage(saveFileDialog.FileName, ChartImageFormat.Png);
            }
        }
    }
}