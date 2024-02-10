namespace Sorting
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._saveAllCharts = new System.Windows.Forms.ToolStripMenuItem();
            this._sortsSelector = new System.Windows.Forms.ToolStripMenuItem();
            this._compareCharts = new System.Windows.Forms.ToolStripMenuItem();
            this._helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._arrayParameters = new System.Windows.Forms.GroupBox();
            this._rangeOfNumbers = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this._maxArrayElement = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this._minArrayElement = new System.Windows.Forms.NumericUpDown();
            this._arraySizes = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._arrayLengthChangeStep = new System.Windows.Forms.NumericUpDown();
            this._endArrayLength = new System.Windows.Forms.NumericUpDown();
            this._startArrayLength = new System.Windows.Forms.NumericUpDown();
            this._start = new System.Windows.Forms.Button();
            this._clearForm = new System.Windows.Forms.Button();
            this._error = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this._exchangeCountGrid = new System.Windows.Forms.DataGridView();
            this.Length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._comparisonCountGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this._arraysDescription = new System.Windows.Forms.TextBox();
            this._tabControl = new System.Windows.Forms.TabControl();
            this._progressBar = new System.Windows.Forms.ProgressBar();
            this.menuStrip1.SuspendLayout();
            this._arrayParameters.SuspendLayout();
            this._rangeOfNumbers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._maxArrayElement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._minArrayElement)).BeginInit();
            this._arraySizes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._arrayLengthChangeStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._endArrayLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._startArrayLength)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._exchangeCountGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._comparisonCountGrid)).BeginInit();
            this.tabPage1.SuspendLayout();
            this._tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.файлToolStripMenuItem, this._sortsSelector, this._compareCharts, this._helpMenuItem, this._exitMenuItem });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(601, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this._saveAllCharts });
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(53, 23);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // _saveAllCharts
            // 
            this._saveAllCharts.Name = "_saveAllCharts";
            this._saveAllCharts.Size = new System.Drawing.Size(226, 24);
            this._saveAllCharts.Text = "Сохранить все графики";
            this._saveAllCharts.Click += new System.EventHandler(this.OnSaveAllChartsClicked);
            // 
            // _sortsSelector
            // 
            this._sortsSelector.Name = "_sortsSelector";
            this._sortsSelector.Size = new System.Drawing.Size(141, 23);
            this._sortsSelector.Text = "Выбор сортировки";
            // 
            // _compareCharts
            // 
            this._compareCharts.Enabled = false;
            this._compareCharts.Name = "_compareCharts";
            this._compareCharts.Size = new System.Drawing.Size(81, 23);
            this._compareCharts.Text = "Сравнить";
            // 
            // _helpMenuItem
            // 
            this._helpMenuItem.Name = "_helpMenuItem";
            this._helpMenuItem.Size = new System.Drawing.Size(74, 23);
            this._helpMenuItem.Text = "Справка";
            this._helpMenuItem.Click += new System.EventHandler(this.OnHelpClicked);
            // 
            // _exitMenuItem
            // 
            this._exitMenuItem.Name = "_exitMenuItem";
            this._exitMenuItem.Size = new System.Drawing.Size(61, 23);
            this._exitMenuItem.Text = "Выход";
            this._exitMenuItem.Click += new System.EventHandler(this.OnCloseClicked);
            // 
            // _arrayParameters
            // 
            this._arrayParameters.Controls.Add(this._rangeOfNumbers);
            this._arrayParameters.Controls.Add(this._arraySizes);
            this._arrayParameters.Location = new System.Drawing.Point(12, 30);
            this._arrayParameters.Name = "_arrayParameters";
            this._arrayParameters.Size = new System.Drawing.Size(335, 135);
            this._arrayParameters.TabIndex = 1;
            this._arrayParameters.TabStop = false;
            this._arrayParameters.Text = "Параметры массивов";
            // 
            // _rangeOfNumbers
            // 
            this._rangeOfNumbers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._rangeOfNumbers.Controls.Add(this.label5);
            this._rangeOfNumbers.Controls.Add(this._maxArrayElement);
            this._rangeOfNumbers.Controls.Add(this.label4);
            this._rangeOfNumbers.Controls.Add(this._minArrayElement);
            this._rangeOfNumbers.Location = new System.Drawing.Point(176, 19);
            this._rangeOfNumbers.Name = "_rangeOfNumbers";
            this._rangeOfNumbers.Size = new System.Drawing.Size(153, 111);
            this._rangeOfNumbers.TabIndex = 1;
            this._rangeOfNumbers.TabStop = false;
            this._rangeOfNumbers.Text = "Диапозон чисел";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Location = new System.Drawing.Point(6, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Максимальное";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _maxArrayElement
            // 
            this._maxArrayElement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._maxArrayElement.Location = new System.Drawing.Point(102, 51);
            this._maxArrayElement.Minimum = new decimal(new int[] { 100, 0, 0, -2147483648 });
            this._maxArrayElement.Name = "_maxArrayElement";
            this._maxArrayElement.Size = new System.Drawing.Size(45, 20);
            this._maxArrayElement.TabIndex = 6;
            this._maxArrayElement.Value = new decimal(new int[] { 9, 0, 0, 0 });
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Location = new System.Drawing.Point(6, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Минимальное";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _minArrayElement
            // 
            this._minArrayElement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._minArrayElement.Location = new System.Drawing.Point(102, 25);
            this._minArrayElement.Minimum = new decimal(new int[] { 100, 0, 0, -2147483648 });
            this._minArrayElement.Name = "_minArrayElement";
            this._minArrayElement.Size = new System.Drawing.Size(45, 20);
            this._minArrayElement.TabIndex = 4;
            this._minArrayElement.Value = new decimal(new int[] { 9, 0, 0, -2147483648 });
            // 
            // _arraySizes
            // 
            this._arraySizes.Controls.Add(this.label3);
            this._arraySizes.Controls.Add(this.label2);
            this._arraySizes.Controls.Add(this.label1);
            this._arraySizes.Controls.Add(this._arrayLengthChangeStep);
            this._arraySizes.Controls.Add(this._endArrayLength);
            this._arraySizes.Controls.Add(this._startArrayLength);
            this._arraySizes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._arraySizes.Location = new System.Drawing.Point(7, 19);
            this._arraySizes.Name = "_arraySizes";
            this._arraySizes.Size = new System.Drawing.Size(158, 111);
            this._arraySizes.TabIndex = 0;
            this._arraySizes.TabStop = false;
            this._arraySizes.Text = "Размеры";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Шаг изменения";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Конечный";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Начальный";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _arrayLengthChangeStep
            // 
            this._arrayLengthChangeStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._arrayLengthChangeStep.Location = new System.Drawing.Point(107, 77);
            this._arrayLengthChangeStep.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this._arrayLengthChangeStep.Name = "_arrayLengthChangeStep";
            this._arrayLengthChangeStep.Size = new System.Drawing.Size(45, 20);
            this._arrayLengthChangeStep.TabIndex = 2;
            this._arrayLengthChangeStep.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // _endArrayLength
            // 
            this._endArrayLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._endArrayLength.Location = new System.Drawing.Point(107, 51);
            this._endArrayLength.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this._endArrayLength.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this._endArrayLength.Name = "_endArrayLength";
            this._endArrayLength.Size = new System.Drawing.Size(45, 20);
            this._endArrayLength.TabIndex = 1;
            this._endArrayLength.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // _startArrayLength
            // 
            this._startArrayLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._startArrayLength.Location = new System.Drawing.Point(107, 25);
            this._startArrayLength.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this._startArrayLength.Name = "_startArrayLength";
            this._startArrayLength.Size = new System.Drawing.Size(45, 20);
            this._startArrayLength.TabIndex = 0;
            this._startArrayLength.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // _start
            // 
            this._start.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._start.Location = new System.Drawing.Point(353, 97);
            this._start.Name = "_start";
            this._start.Size = new System.Drawing.Size(115, 44);
            this._start.TabIndex = 2;
            this._start.Text = "Начать расчёт";
            this._start.UseVisualStyleBackColor = true;
            this._start.Click += new System.EventHandler(this.OnStartClicked);
            // 
            // _clearForm
            // 
            this._clearForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._clearForm.Location = new System.Drawing.Point(474, 97);
            this._clearForm.Name = "_clearForm";
            this._clearForm.Size = new System.Drawing.Size(111, 44);
            this._clearForm.TabIndex = 3;
            this._clearForm.Text = "Очистить форму";
            this._clearForm.UseVisualStyleBackColor = true;
            this._clearForm.Click += new System.EventHandler(this.OnClearFormClicked);
            // 
            // _error
            // 
            this._error.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._error.Location = new System.Drawing.Point(353, 49);
            this._error.Name = "_error";
            this._error.Size = new System.Drawing.Size(232, 45);
            this._error.TabIndex = 5;
            this._error.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this._exchangeCountGrid);
            this.tabPage2.Controls.Add(this._comparisonCountGrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(569, 187);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Таблицы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(289, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(278, 21);
            this.label8.TabIndex = 3;
            this.label8.Text = "Обмены";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(6, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(277, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "Сравнения";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _exchangeCountGrid
            // 
            this._exchangeCountGrid.AllowUserToAddRows = false;
            this._exchangeCountGrid.AllowUserToDeleteRows = false;
            this._exchangeCountGrid.AllowUserToResizeColumns = false;
            this._exchangeCountGrid.AllowUserToResizeRows = false;
            this._exchangeCountGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Right)));
            this._exchangeCountGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._exchangeCountGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.Length });
            this._exchangeCountGrid.Location = new System.Drawing.Point(277, 30);
            this._exchangeCountGrid.Name = "_exchangeCountGrid";
            this._exchangeCountGrid.ReadOnly = true;
            this._exchangeCountGrid.RowHeadersVisible = false;
            this._exchangeCountGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this._exchangeCountGrid.Size = new System.Drawing.Size(278, 131);
            this._exchangeCountGrid.TabIndex = 1;
            // 
            // Length
            // 
            this.Length.HeaderText = "Длина";
            this.Length.Name = "Length";
            this.Length.ReadOnly = true;
            // 
            // _comparisonCountGrid
            // 
            this._comparisonCountGrid.AllowUserToAddRows = false;
            this._comparisonCountGrid.AllowUserToDeleteRows = false;
            this._comparisonCountGrid.AllowUserToResizeColumns = false;
            this._comparisonCountGrid.AllowUserToResizeRows = false;
            this._comparisonCountGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this._comparisonCountGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._comparisonCountGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.dataGridViewTextBoxColumn1 });
            this._comparisonCountGrid.Location = new System.Drawing.Point(6, 30);
            this._comparisonCountGrid.Name = "_comparisonCountGrid";
            this._comparisonCountGrid.ReadOnly = true;
            this._comparisonCountGrid.RowHeadersVisible = false;
            this._comparisonCountGrid.Size = new System.Drawing.Size(277, 131);
            this._comparisonCountGrid.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Длина";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this._arraysDescription);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(569, 187);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Массивы";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // _arraysDescription
            // 
            this._arraysDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this._arraysDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._arraysDescription.Location = new System.Drawing.Point(3, 3);
            this._arraysDescription.Multiline = true;
            this._arraysDescription.Name = "_arraysDescription";
            this._arraysDescription.ReadOnly = true;
            this._arraysDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._arraysDescription.Size = new System.Drawing.Size(563, 181);
            this._arraysDescription.TabIndex = 0;
            // 
            // _tabControl
            // 
            this._tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this._tabControl.Controls.Add(this.tabPage1);
            this._tabControl.Controls.Add(this.tabPage2);
            this._tabControl.Location = new System.Drawing.Point(12, 171);
            this._tabControl.Name = "_tabControl";
            this._tabControl.SelectedIndex = 0;
            this._tabControl.Size = new System.Drawing.Size(577, 213);
            this._tabControl.TabIndex = 4;
            // 
            // _progressBar
            // 
            this._progressBar.Location = new System.Drawing.Point(353, 147);
            this._progressBar.Name = "_progressBar";
            this._progressBar.Size = new System.Drawing.Size(232, 18);
            this._progressBar.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 396);
            this.Controls.Add(this._progressBar);
            this.Controls.Add(this._error);
            this.Controls.Add(this._tabControl);
            this.Controls.Add(this._clearForm);
            this.Controls.Add(this._start);
            this.Controls.Add(this._arrayParameters);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Сортировки числовых массивов";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this._arrayParameters.ResumeLayout(false);
            this._rangeOfNumbers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._maxArrayElement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._minArrayElement)).EndInit();
            this._arraySizes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._arrayLengthChangeStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._endArrayLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._startArrayLength)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._exchangeCountGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._comparisonCountGrid)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this._tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ProgressBar _progressBar;

        private System.Windows.Forms.ToolStripMenuItem _compareCharts;

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;

        private System.Windows.Forms.DataGridViewTextBoxColumn Length;

        private System.Windows.Forms.ToolStripMenuItem _sortsSelector;

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;

        private System.Windows.Forms.DataGridView _exchangeCountGrid;

        private System.Windows.Forms.DataGridView _comparisonCountGrid;

        private System.Windows.Forms.TextBox _arraysDescription;

        private System.Windows.Forms.Label _error;

        private System.Windows.Forms.TabControl _tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;

        private System.Windows.Forms.Button _start;
        private System.Windows.Forms.Button _clearForm;

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown _maxArrayElement;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown _minArrayElement;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.NumericUpDown _arrayLengthChangeStep;

        private System.Windows.Forms.NumericUpDown _startArrayLength;
        private System.Windows.Forms.NumericUpDown _endArrayLength;
        private System.Windows.Forms.GroupBox _arraySizes;
        private System.Windows.Forms.GroupBox _rangeOfNumbers;
        private System.Windows.Forms.ToolStripMenuItem _helpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _exitMenuItem;
        private System.Windows.Forms.GroupBox _arrayParameters;
        private System.Windows.Forms.ToolStripMenuItem _saveAllCharts;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;

        #endregion
    }
}