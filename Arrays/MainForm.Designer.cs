namespace Arrays
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this._arrayTask = new System.Windows.Forms.StatusStrip();
            this._arrayTaskLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this._arrayInformation = new System.Windows.Forms.Label();
            this._testsProgress = new System.Windows.Forms.ProgressBar();
            this._arraysTable = new System.Windows.Forms.DataGridView();
            this._arraysStartButton = new System.Windows.Forms.Button();
            this._arraysResetButton = new System.Windows.Forms.Button();
            this._drawGraphicCheckBox = new System.Windows.Forms.CheckBox();
            this._drawTableCheckBox = new System.Windows.Forms.CheckBox();
            this._startArrayLength = new System.Windows.Forms.NumericUpDown();
            this._endArrayLength = new System.Windows.Forms.NumericUpDown();
            this._minArrayValue = new System.Windows.Forms.NumericUpDown();
            this._maxArrayValue = new System.Windows.Forms.NumericUpDown();
            this._lengthChangeStep = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this._chartOfNumberOfExchanges = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this._chartOfNumberOfComparisons = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this._tasksCheckedList = new System.Windows.Forms.CheckedListBox();
            this._matrixTask = new System.Windows.Forms.StatusStrip();
            this._matrixTaskLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this._resultMatrix = new System.Windows.Forms.DataGridView();
            this._initialMatrix = new System.Windows.Forms.DataGridView();
            this._matrixInformation = new System.Windows.Forms.Label();
            this._dimensionOfMatrix = new System.Windows.Forms.NumericUpDown();
            this._minMatrixValue = new System.Windows.Forms.NumericUpDown();
            this._maxMatrixValue = new System.Windows.Forms.NumericUpDown();
            this._matrixStartButton = new System.Windows.Forms.Button();
            this._matrixResetButton = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this._arrayTask.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._arraysTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._startArrayLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._endArrayLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._minArrayValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._maxArrayValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lengthChangeStep)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._chartOfNumberOfExchanges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._chartOfNumberOfComparisons)).BeginInit();
            this.tabPage2.SuspendLayout();
            this._matrixTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._resultMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._initialMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dimensionOfMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._minMatrixValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._maxMatrixValue)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(658, 564);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this._arrayTask);
            this.tabPage1.Controls.Add(this.tabControl2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(650, 538);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Массив";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // _arrayTask
            // 
            this._arrayTask.Font = new System.Drawing.Font("Segoe UI", 9F);
            this._arrayTask.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this._arrayTaskLabel });
            this._arrayTask.Location = new System.Drawing.Point(2, 514);
            this._arrayTask.Name = "_arrayTask";
            this._arrayTask.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this._arrayTask.Size = new System.Drawing.Size(646, 22);
            this._arrayTask.TabIndex = 19;
            this._arrayTask.Text = "statusStrip1";
            // 
            // _arrayTaskLabel
            // 
            this._arrayTaskLabel.Name = "_arrayTaskLabel";
            this._arrayTaskLabel.Size = new System.Drawing.Size(569, 17);

            this._arrayTaskLabel.Text = "Нули удалить, положительные элементы расставить по убыванию, а отрицательные по в" +
                                        "озрастанию";

            this._arrayTaskLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.ItemSize = new System.Drawing.Size(300, 31);
            this.tabControl2.Location = new System.Drawing.Point(2, 2);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(646, 534);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this._arrayInformation);
            this.tabPage3.Controls.Add(this._testsProgress);
            this.tabPage3.Controls.Add(this._arraysTable);
            this.tabPage3.Controls.Add(this._arraysStartButton);
            this.tabPage3.Controls.Add(this._arraysResetButton);
            this.tabPage3.Controls.Add(this._drawGraphicCheckBox);
            this.tabPage3.Controls.Add(this._drawTableCheckBox);
            this.tabPage3.Controls.Add(this._startArrayLength);
            this.tabPage3.Controls.Add(this._endArrayLength);
            this.tabPage3.Controls.Add(this._minArrayValue);
            this.tabPage3.Controls.Add(this._maxArrayValue);
            this.tabPage3.Controls.Add(this._lengthChangeStep);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 35);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Size = new System.Drawing.Size(638, 495);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Тестирование и использование";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // _arrayInformation
            // 
            this._arrayInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._arrayInformation.Location = new System.Drawing.Point(223, 153);
            this._arrayInformation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._arrayInformation.Name = "_arrayInformation";
            this._arrayInformation.Size = new System.Drawing.Size(392, 35);
            this._arrayInformation.TabIndex = 17;
            this._arrayInformation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _testsProgress
            // 
            this._testsProgress.Location = new System.Drawing.Point(20, 449);
            this._testsProgress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._testsProgress.Name = "_testsProgress";
            this._testsProgress.Size = new System.Drawing.Size(595, 27);
            this._testsProgress.TabIndex = 17;
            // 
            // _arraysTable
            // 
            this._arraysTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._arraysTable.Location = new System.Drawing.Point(20, 200);
            this._arraysTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._arraysTable.Name = "_arraysTable";
            this._arraysTable.ReadOnly = true;
            this._arraysTable.RowHeadersWidth = 82;
            this._arraysTable.RowTemplate.Height = 33;
            this._arraysTable.Size = new System.Drawing.Size(595, 245);
            this._arraysTable.TabIndex = 16;
            // 
            // _arraysStartButton
            // 
            this._arraysStartButton.Location = new System.Drawing.Point(518, 55);
            this._arraysStartButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._arraysStartButton.Name = "_arraysStartButton";
            this._arraysStartButton.Size = new System.Drawing.Size(56, 25);
            this._arraysStartButton.TabIndex = 15;
            this._arraysStartButton.Text = "ПУСК";
            this._arraysStartButton.UseVisualStyleBackColor = true;
            this._arraysStartButton.Click += new System.EventHandler(this.OnArraysStartClicked);
            // 
            // _arraysResetButton
            // 
            this._arraysResetButton.Location = new System.Drawing.Point(518, 107);
            this._arraysResetButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._arraysResetButton.Name = "_arraysResetButton";
            this._arraysResetButton.Size = new System.Drawing.Size(56, 25);
            this._arraysResetButton.TabIndex = 14;
            this._arraysResetButton.Text = "СБРОС";
            this._arraysResetButton.UseVisualStyleBackColor = true;
            this._arraysResetButton.Click += new System.EventHandler(this.OnArraysResetClicked);
            // 
            // _drawGraphicCheckBox
            // 
            this._drawGraphicCheckBox.AutoSize = true;
            this._drawGraphicCheckBox.Location = new System.Drawing.Point(387, 114);
            this._drawGraphicCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._drawGraphicCheckBox.Name = "_drawGraphicCheckBox";
            this._drawGraphicCheckBox.Size = new System.Drawing.Size(79, 17);
            this._drawGraphicCheckBox.TabIndex = 13;
            this._drawGraphicCheckBox.Text = "В графики";
            this._drawGraphicCheckBox.UseVisualStyleBackColor = true;
            // 
            // _drawTableCheckBox
            // 
            this._drawTableCheckBox.AutoSize = true;
            this._drawTableCheckBox.Location = new System.Drawing.Point(387, 60);
            this._drawTableCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._drawTableCheckBox.Name = "_drawTableCheckBox";
            this._drawTableCheckBox.Size = new System.Drawing.Size(76, 17);
            this._drawTableCheckBox.TabIndex = 12;
            this._drawTableCheckBox.Text = "В таблицу";
            this._drawTableCheckBox.UseVisualStyleBackColor = true;
            // 
            // _startArrayLength
            // 
            this._startArrayLength.Location = new System.Drawing.Point(102, 60);
            this._startArrayLength.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._startArrayLength.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this._startArrayLength.Name = "_startArrayLength";
            this._startArrayLength.Size = new System.Drawing.Size(60, 20);
            this._startArrayLength.TabIndex = 11;
            this._startArrayLength.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // _endArrayLength
            // 
            this._endArrayLength.Location = new System.Drawing.Point(102, 111);
            this._endArrayLength.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._endArrayLength.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this._endArrayLength.Name = "_endArrayLength";
            this._endArrayLength.Size = new System.Drawing.Size(60, 20);
            this._endArrayLength.TabIndex = 10;
            this._endArrayLength.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // _minArrayValue
            // 
            this._minArrayValue.Location = new System.Drawing.Point(253, 111);
            this._minArrayValue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._minArrayValue.Maximum = new decimal(new int[] { 0, 0, 0, 0 });
            this._minArrayValue.Minimum = new decimal(new int[] { 100, 0, 0, -2147483648 });
            this._minArrayValue.Name = "_minArrayValue";
            this._minArrayValue.Size = new System.Drawing.Size(60, 20);
            this._minArrayValue.TabIndex = 9;
            this._minArrayValue.Value = new decimal(new int[] { 9, 0, 0, -2147483648 });
            // 
            // _maxArrayValue
            // 
            this._maxArrayValue.Location = new System.Drawing.Point(253, 59);
            this._maxArrayValue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._maxArrayValue.Name = "_maxArrayValue";
            this._maxArrayValue.Size = new System.Drawing.Size(60, 20);
            this._maxArrayValue.TabIndex = 8;
            this._maxArrayValue.Value = new decimal(new int[] { 9, 0, 0, 0 });
            // 
            // _lengthChangeStep
            // 
            this._lengthChangeStep.Location = new System.Drawing.Point(102, 162);
            this._lengthChangeStep.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._lengthChangeStep.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            this._lengthChangeStep.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this._lengthChangeStep.Name = "_lengthChangeStep";
            this._lengthChangeStep.Size = new System.Drawing.Size(60, 20);
            this._lengthChangeStep.TabIndex = 7;
            this._lengthChangeStep.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 163);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Шаг";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(223, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Диапазон";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 114);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "мин";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Конечный";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(20, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Размер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "мах";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Начальный";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this._chartOfNumberOfExchanges);
            this.tabPage4.Controls.Add(this._chartOfNumberOfComparisons);
            this.tabPage4.Location = new System.Drawing.Point(4, 35);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage4.Size = new System.Drawing.Size(651, 551);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Графика";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // _chartOfNumberOfExchanges
            // 
            chartArea1.Name = "ChartArea1";
            this._chartOfNumberOfExchanges.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this._chartOfNumberOfExchanges.Legends.Add(legend1);
            this._chartOfNumberOfExchanges.Location = new System.Drawing.Point(4, 247);
            this._chartOfNumberOfExchanges.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._chartOfNumberOfExchanges.Name = "_chartOfNumberOfExchanges";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this._chartOfNumberOfExchanges.Series.Add(series1);
            this._chartOfNumberOfExchanges.Size = new System.Drawing.Size(622, 222);
            this._chartOfNumberOfExchanges.TabIndex = 1;
            this._chartOfNumberOfExchanges.Text = "_chartOfNumberOfExchanges";
            title1.Name = "Title1";
            title1.Text = "Количество обменов";
            this._chartOfNumberOfExchanges.Titles.Add(title1);
            // 
            // _chartOfNumberOfComparisons
            // 
            chartArea2.Name = "ChartArea1";
            this._chartOfNumberOfComparisons.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this._chartOfNumberOfComparisons.Legends.Add(legend2);
            this._chartOfNumberOfComparisons.Location = new System.Drawing.Point(4, 4);
            this._chartOfNumberOfComparisons.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._chartOfNumberOfComparisons.Name = "_chartOfNumberOfComparisons";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this._chartOfNumberOfComparisons.Series.Add(series2);
            this._chartOfNumberOfComparisons.Size = new System.Drawing.Size(615, 229);
            this._chartOfNumberOfComparisons.TabIndex = 0;
            this._chartOfNumberOfComparisons.Text = "_chartOfNumberOfComparisons";
            title2.Name = "Title1";
            title2.Text = "Количество сравнений";
            this._chartOfNumberOfComparisons.Titles.Add(title2);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this._tasksCheckedList);
            this.tabPage2.Controls.Add(this._matrixTask);
            this.tabPage2.Controls.Add(this._resultMatrix);
            this.tabPage2.Controls.Add(this._initialMatrix);
            this.tabPage2.Controls.Add(this._matrixInformation);
            this.tabPage2.Controls.Add(this._dimensionOfMatrix);
            this.tabPage2.Controls.Add(this._minMatrixValue);
            this.tabPage2.Controls.Add(this._maxMatrixValue);
            this.tabPage2.Controls.Add(this._matrixStartButton);
            this.tabPage2.Controls.Add(this._matrixResetButton);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(650, 538);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Матрица";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // _tasksCheckedList
            // 
            this._tasksCheckedList.CheckOnClick = true;
            this._tasksCheckedList.FormattingEnabled = true;
            this._tasksCheckedList.Items.AddRange(new object[] { "Общее задание", "Индивидуальное задание" });
            this._tasksCheckedList.Location = new System.Drawing.Point(14, 181);
            this._tasksCheckedList.Name = "_tasksCheckedList";
            this._tasksCheckedList.Size = new System.Drawing.Size(156, 34);
            this._tasksCheckedList.TabIndex = 17;
            this._tasksCheckedList.SelectedIndexChanged += new System.EventHandler(this.OnMatrixTaskChanged);
            // 
            // _matrixTask
            // 
            this._matrixTask.Font = new System.Drawing.Font("Segoe UI", 9F);
            this._matrixTask.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this._matrixTaskLabel });
            this._matrixTask.Location = new System.Drawing.Point(2, 514);
            this._matrixTask.Name = "_matrixTask";
            this._matrixTask.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this._matrixTask.Size = new System.Drawing.Size(646, 22);
            this._matrixTask.TabIndex = 14;
            this._matrixTask.Text = "statusStrip2";
            // 
            // _matrixTaskLabel
            // 
            this._matrixTaskLabel.Name = "_matrixTaskLabel";
            this._matrixTaskLabel.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this._matrixTaskLabel.Size = new System.Drawing.Size(107, 17);
            this._matrixTaskLabel.Text = "Выберите задание";
            // 
            // _resultMatrix
            // 
            this._resultMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._resultMatrix.Location = new System.Drawing.Point(215, 283);
            this._resultMatrix.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._resultMatrix.Name = "_resultMatrix";
            this._resultMatrix.ReadOnly = true;
            this._resultMatrix.RowHeadersWidth = 82;
            this._resultMatrix.RowTemplate.Height = 33;
            this._resultMatrix.Size = new System.Drawing.Size(409, 219);
            this._resultMatrix.TabIndex = 13;
            // 
            // _initialMatrix
            // 
            this._initialMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._initialMatrix.Location = new System.Drawing.Point(215, 38);
            this._initialMatrix.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._initialMatrix.Name = "_initialMatrix";
            this._initialMatrix.ReadOnly = true;
            this._initialMatrix.RowHeadersWidth = 82;
            this._initialMatrix.RowTemplate.Height = 33;
            this._initialMatrix.Size = new System.Drawing.Size(409, 208);
            this._initialMatrix.TabIndex = 12;
            // 
            // _matrixInformation
            // 
            this._matrixInformation.Location = new System.Drawing.Point(215, 504);
            this._matrixInformation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._matrixInformation.Name = "_matrixInformation";
            this._matrixInformation.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._matrixInformation.Size = new System.Drawing.Size(409, 20);
            this._matrixInformation.TabIndex = 11;
            this._matrixInformation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _dimensionOfMatrix
            // 
            this._dimensionOfMatrix.Location = new System.Drawing.Point(95, 28);
            this._dimensionOfMatrix.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._dimensionOfMatrix.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            this._dimensionOfMatrix.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this._dimensionOfMatrix.Name = "_dimensionOfMatrix";
            this._dimensionOfMatrix.Size = new System.Drawing.Size(60, 20);
            this._dimensionOfMatrix.TabIndex = 10;
            this._dimensionOfMatrix.Value = new decimal(new int[] { 9, 0, 0, 0 });
            // 
            // _minMatrixValue
            // 
            this._minMatrixValue.Location = new System.Drawing.Point(58, 116);
            this._minMatrixValue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._minMatrixValue.Minimum = new decimal(new int[] { 100, 0, 0, -2147483648 });
            this._minMatrixValue.Name = "_minMatrixValue";
            this._minMatrixValue.Size = new System.Drawing.Size(60, 20);
            this._minMatrixValue.TabIndex = 9;
            this._minMatrixValue.Value = new decimal(new int[] { 9, 0, 0, -2147483648 });
            // 
            // _maxMatrixValue
            // 
            this._maxMatrixValue.Location = new System.Drawing.Point(58, 89);
            this._maxMatrixValue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._maxMatrixValue.Minimum = new decimal(new int[] { 100, 0, 0, -2147483648 });
            this._maxMatrixValue.Name = "_maxMatrixValue";
            this._maxMatrixValue.Size = new System.Drawing.Size(60, 20);
            this._maxMatrixValue.TabIndex = 8;
            this._maxMatrixValue.Value = new decimal(new int[] { 9, 0, 0, 0 });
            // 
            // _matrixStartButton
            // 
            this._matrixStartButton.Enabled = false;
            this._matrixStartButton.Location = new System.Drawing.Point(14, 220);
            this._matrixStartButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._matrixStartButton.Name = "_matrixStartButton";
            this._matrixStartButton.Size = new System.Drawing.Size(75, 26);
            this._matrixStartButton.TabIndex = 7;
            this._matrixStartButton.Text = "Старт";
            this._matrixStartButton.UseVisualStyleBackColor = true;
            // 
            // _matrixResetButton
            // 
            this._matrixResetButton.Location = new System.Drawing.Point(93, 220);
            this._matrixResetButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._matrixResetButton.Name = "_matrixResetButton";
            this._matrixResetButton.Size = new System.Drawing.Size(77, 26);
            this._matrixResetButton.TabIndex = 6;
            this._matrixResetButton.Text = "Сброс";
            this._matrixResetButton.UseVisualStyleBackColor = true;
            this._matrixResetButton.Click += new System.EventHandler(this.OnMatrixResetClicked);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 28);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Размер";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(356, 23);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Исходная матрица";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(352, 268);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Матрица-результат";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(14, 67);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Диапазон чисел";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 91);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "max";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 118);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "min";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(658, 564);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Массивы";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this._arrayTask.ResumeLayout(false);
            this._arrayTask.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._arraysTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._startArrayLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._endArrayLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._minArrayValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._maxArrayValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lengthChangeStep)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._chartOfNumberOfExchanges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._chartOfNumberOfComparisons)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this._matrixTask.ResumeLayout(false);
            this._matrixTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._resultMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._initialMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._dimensionOfMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._minMatrixValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._maxMatrixValue)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.CheckedListBox _tasksCheckedList;

        private System.Windows.Forms.ToolStripStatusLabel _matrixTaskLabel;

        private System.Windows.Forms.StatusStrip _matrixTask;

        private System.Windows.Forms.ToolStripStatusLabel _arrayTaskLabel;

        private System.Windows.Forms.StatusStrip _arrayTask;

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label _arrayInformation;
        private System.Windows.Forms.ProgressBar _testsProgress;
        private System.Windows.Forms.DataGridView _arraysTable;
        private System.Windows.Forms.Button _arraysStartButton;
        private System.Windows.Forms.Button _arraysResetButton;
        private System.Windows.Forms.CheckBox _drawGraphicCheckBox;
        private System.Windows.Forms.CheckBox _drawTableCheckBox;
        private System.Windows.Forms.NumericUpDown _startArrayLength;
        private System.Windows.Forms.NumericUpDown _endArrayLength;
        private System.Windows.Forms.NumericUpDown _minArrayValue;
        private System.Windows.Forms.NumericUpDown _maxArrayValue;
        private System.Windows.Forms.NumericUpDown _lengthChangeStep;
        private System.Windows.Forms.DataVisualization.Charting.Chart _chartOfNumberOfExchanges;
        private System.Windows.Forms.DataVisualization.Charting.Chart _chartOfNumberOfComparisons;
        private System.Windows.Forms.NumericUpDown _dimensionOfMatrix;
        private System.Windows.Forms.NumericUpDown _minMatrixValue;
        private System.Windows.Forms.NumericUpDown _maxMatrixValue;
        private System.Windows.Forms.Button _matrixStartButton;
        private System.Windows.Forms.Button _matrixResetButton;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView _resultMatrix;
        private System.Windows.Forms.DataGridView _initialMatrix;
        private System.Windows.Forms.Label _matrixInformation;
    }
}

