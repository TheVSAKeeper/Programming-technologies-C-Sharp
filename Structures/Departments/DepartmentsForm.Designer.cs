using System.ComponentModel;

namespace Structures.Departments
{
    partial class DepartmentsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this._dataGrid = new System.Windows.Forms.DataGridView();
            this._departmentNameLabel = new System.Windows.Forms.Label();
            this._departmentName = new System.Windows.Forms.TextBox();
            this._headFullNameLabel = new System.Windows.Forms.Label();
            this._teachersCountLabel = new System.Windows.Forms.Label();
            this._requestPanel = new System.Windows.Forms.TableLayoutPanel();
            this._teachersCountRequest = new System.Windows.Forms.RadioButton();
            this._requestContent = new System.Windows.Forms.NumericUpDown();
            this._search = new System.Windows.Forms.Button();
            this._sampleGrid = new System.Windows.Forms.DataGridView();
            this._sample = new System.Windows.Forms.GroupBox();
            this._data = new System.Windows.Forms.GroupBox();
            this._request = new System.Windows.Forms.GroupBox();
            this._dataGridsPanel = new System.Windows.Forms.TableLayoutPanel();
            this._helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._searchMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._addDataMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._actionsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this._addressLabel = new System.Windows.Forms.Label();
            this._exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._dataInput = new System.Windows.Forms.GroupBox();
            this._dataInputPanel = new System.Windows.Forms.TableLayoutPanel();
            this._headFullName = new System.Windows.Forms.TextBox();
            this._teachersCount = new System.Windows.Forms.NumericUpDown();
            this._address = new System.Windows.Forms.TextBox();
            this._addData = new System.Windows.Forms.Button();
            this._toolBar = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this._dataGrid)).BeginInit();
            this._requestPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._requestContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._sampleGrid)).BeginInit();
            this._sample.SuspendLayout();
            this._data.SuspendLayout();
            this._request.SuspendLayout();
            this._dataGridsPanel.SuspendLayout();
            this._dataInput.SuspendLayout();
            this._dataInputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._teachersCount)).BeginInit();
            this._toolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // _dataGrid
            // 
            this._dataGrid.AllowUserToAddRows = false;
            this._dataGrid.AllowUserToDeleteRows = false;
            this._dataGrid.AllowUserToResizeColumns = false;
            this._dataGrid.AllowUserToResizeRows = false;
            this._dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dataGrid.Location = new System.Drawing.Point(3, 16);
            this._dataGrid.Name = "_dataGrid";
            this._dataGrid.ReadOnly = true;
            this._dataGrid.RowHeadersVisible = false;
            this._dataGrid.Size = new System.Drawing.Size(494, 175);
            this._dataGrid.TabIndex = 0;
            // 
            // _departmentNameLabel
            // 
            this._departmentNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._departmentNameLabel.Location = new System.Drawing.Point(3, 3);
            this._departmentNameLabel.Margin = new System.Windows.Forms.Padding(3);
            this._departmentNameLabel.Name = "_departmentNameLabel";
            this._departmentNameLabel.Size = new System.Drawing.Size(147, 24);
            this._departmentNameLabel.TabIndex = 1;
            this._departmentNameLabel.Text = "Название кафедры";
            this._departmentNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _departmentName
            // 
            this._departmentName.Dock = System.Windows.Forms.DockStyle.Fill;
            this._departmentName.Location = new System.Drawing.Point(3, 33);
            this._departmentName.Name = "_departmentName";
            this._departmentName.Size = new System.Drawing.Size(147, 20);
            this._departmentName.TabIndex = 2;
            // 
            // _headFullNameLabel
            // 
            this._headFullNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._headFullNameLabel.Location = new System.Drawing.Point(3, 59);
            this._headFullNameLabel.Margin = new System.Windows.Forms.Padding(3);
            this._headFullNameLabel.Name = "_headFullNameLabel";
            this._headFullNameLabel.Size = new System.Drawing.Size(147, 24);
            this._headFullNameLabel.TabIndex = 3;
            this._headFullNameLabel.Text = "ФИО зав. кафедрой";
            this._headFullNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _teachersCountLabel
            // 
            this._teachersCountLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._teachersCountLabel.Location = new System.Drawing.Point(3, 115);
            this._teachersCountLabel.Margin = new System.Windows.Forms.Padding(3);
            this._teachersCountLabel.Name = "_teachersCountLabel";
            this._teachersCountLabel.Size = new System.Drawing.Size(147, 24);
            this._teachersCountLabel.TabIndex = 5;
            this._teachersCountLabel.Text = "Кол-во преподавателей";
            this._teachersCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _requestPanel
            // 
            this._requestPanel.ColumnCount = 1;
            this._requestPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._requestPanel.Controls.Add(this._teachersCountRequest, 0, 0);
            this._requestPanel.Controls.Add(this._requestContent, 0, 1);
            this._requestPanel.Controls.Add(this._search, 0, 2);
            this._requestPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._requestPanel.Location = new System.Drawing.Point(3, 16);
            this._requestPanel.Name = "_requestPanel";
            this._requestPanel.RowCount = 3;
            this._requestPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this._requestPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._requestPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this._requestPanel.Size = new System.Drawing.Size(150, 102);
            this._requestPanel.TabIndex = 0;
            // 
            // _teachersCountRequest
            // 
            this._teachersCountRequest.Checked = true;
            this._teachersCountRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this._teachersCountRequest.Location = new System.Drawing.Point(3, 3);
            this._teachersCountRequest.Name = "_teachersCountRequest";
            this._teachersCountRequest.Size = new System.Drawing.Size(144, 34);
            this._teachersCountRequest.TabIndex = 0;
            this._teachersCountRequest.TabStop = true;
            this._teachersCountRequest.Text = "Преподавателей\r\nне менее";
            this._teachersCountRequest.UseVisualStyleBackColor = true;
            // 
            // _requestContent
            // 
            this._requestContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this._requestContent.Location = new System.Drawing.Point(3, 43);
            this._requestContent.Name = "_requestContent";
            this._requestContent.Size = new System.Drawing.Size(144, 20);
            this._requestContent.TabIndex = 1;
            // 
            // _search
            // 
            this._search.Dock = System.Windows.Forms.DockStyle.Fill;
            this._search.Location = new System.Drawing.Point(3, 69);
            this._search.Name = "_search";
            this._search.Size = new System.Drawing.Size(144, 30);
            this._search.TabIndex = 2;
            this._search.Text = "Найти";
            this._search.UseVisualStyleBackColor = true;
            this._search.Click += new System.EventHandler(this.OnSearchClicked);
            // 
            // _sampleGrid
            // 
            this._sampleGrid.AllowUserToAddRows = false;
            this._sampleGrid.AllowUserToResizeColumns = false;
            this._sampleGrid.AllowUserToResizeRows = false;
            this._sampleGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._sampleGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._sampleGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this._sampleGrid.Location = new System.Drawing.Point(3, 16);
            this._sampleGrid.Name = "_sampleGrid";
            this._sampleGrid.ReadOnly = true;
            this._sampleGrid.RowHeadersVisible = false;
            this._sampleGrid.Size = new System.Drawing.Size(494, 176);
            this._sampleGrid.TabIndex = 1;
            // 
            // _sample
            // 
            this._sample.Controls.Add(this._sampleGrid);
            this._sample.Dock = System.Windows.Forms.DockStyle.Fill;
            this._sample.Location = new System.Drawing.Point(3, 203);
            this._sample.Name = "_sample";
            this._sample.Size = new System.Drawing.Size(500, 195);
            this._sample.TabIndex = 5;
            this._sample.TabStop = false;
            this._sample.Text = "Выборка";
            // 
            // _data
            // 
            this._data.Controls.Add(this._dataGrid);
            this._data.Dock = System.Windows.Forms.DockStyle.Fill;
            this._data.Location = new System.Drawing.Point(3, 3);
            this._data.Name = "_data";
            this._data.Size = new System.Drawing.Size(500, 194);
            this._data.TabIndex = 4;
            this._data.TabStop = false;
            this._data.Text = "Данные";
            // 
            // _request
            // 
            this._request.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._request.Controls.Add(this._requestPanel);
            this._request.Location = new System.Drawing.Point(12, 310);
            this._request.Name = "_request";
            this._request.Size = new System.Drawing.Size(156, 121);
            this._request.TabIndex = 9;
            this._request.TabStop = false;
            this._request.Text = "Запрос";
            // 
            // _dataGridsPanel
            // 
            this._dataGridsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this._dataGridsPanel.ColumnCount = 1;
            this._dataGridsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._dataGridsPanel.Controls.Add(this._sample, 0, 1);
            this._dataGridsPanel.Controls.Add(this._data, 0, 0);
            this._dataGridsPanel.Location = new System.Drawing.Point(177, 30);
            this._dataGridsPanel.Name = "_dataGridsPanel";
            this._dataGridsPanel.RowCount = 2;
            this._dataGridsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._dataGridsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._dataGridsPanel.Size = new System.Drawing.Size(506, 401);
            this._dataGridsPanel.TabIndex = 10;
            // 
            // _helpMenuItem
            // 
            this._helpMenuItem.Name = "_helpMenuItem";
            this._helpMenuItem.Size = new System.Drawing.Size(74, 23);
            this._helpMenuItem.Text = "Справка";
            this._helpMenuItem.Click += new System.EventHandler(this.OnHelpClicked);
            // 
            // _searchMenuItem
            // 
            this._searchMenuItem.Name = "_searchMenuItem";
            this._searchMenuItem.Size = new System.Drawing.Size(191, 24);
            this._searchMenuItem.Text = "Выполнить поиск";
            this._searchMenuItem.Click += new System.EventHandler(this.OnSearchClicked);
            // 
            // _addDataMenuItem
            // 
            this._addDataMenuItem.Name = "_addDataMenuItem";
            this._addDataMenuItem.Size = new System.Drawing.Size(191, 24);
            this._addDataMenuItem.Text = "Добавить данные";
            this._addDataMenuItem.Click += new System.EventHandler(this.OnAddDataClicked);
            // 
            // _actionsMenu
            // 
            this._actionsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this._addDataMenuItem, this._searchMenuItem });
            this._actionsMenu.Name = "_actionsMenu";
            this._actionsMenu.Size = new System.Drawing.Size(80, 23);
            this._actionsMenu.Text = "Действия";
            // 
            // _addressLabel
            // 
            this._addressLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._addressLabel.Location = new System.Drawing.Point(3, 171);
            this._addressLabel.Margin = new System.Windows.Forms.Padding(3);
            this._addressLabel.Name = "_addressLabel";
            this._addressLabel.Size = new System.Drawing.Size(147, 24);
            this._addressLabel.TabIndex = 7;
            this._addressLabel.Text = "Адрес";
            this._addressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _exitMenuItem
            // 
            this._exitMenuItem.Name = "_exitMenuItem";
            this._exitMenuItem.Size = new System.Drawing.Size(61, 23);
            this._exitMenuItem.Text = "Выход";
            this._exitMenuItem.Click += new System.EventHandler(this.OnExitClicked);
            // 
            // _dataInput
            // 
            this._dataInput.Controls.Add(this._dataInputPanel);
            this._dataInput.Location = new System.Drawing.Point(12, 30);
            this._dataInput.Name = "_dataInput";
            this._dataInput.Size = new System.Drawing.Size(159, 282);
            this._dataInput.TabIndex = 8;
            this._dataInput.TabStop = false;
            this._dataInput.Text = "Ввод данных";
            // 
            // _dataInputPanel
            // 
            this._dataInputPanel.ColumnCount = 1;
            this._dataInputPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._dataInputPanel.Controls.Add(this._departmentNameLabel, 0, 0);
            this._dataInputPanel.Controls.Add(this._departmentName, 0, 1);
            this._dataInputPanel.Controls.Add(this._headFullNameLabel, 0, 2);
            this._dataInputPanel.Controls.Add(this._headFullName, 0, 3);
            this._dataInputPanel.Controls.Add(this._teachersCountLabel, 0, 4);
            this._dataInputPanel.Controls.Add(this._teachersCount, 0, 5);
            this._dataInputPanel.Controls.Add(this._addressLabel, 0, 6);
            this._dataInputPanel.Controls.Add(this._address, 0, 7);
            this._dataInputPanel.Controls.Add(this._addData, 0, 8);
            this._dataInputPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dataInputPanel.Location = new System.Drawing.Point(3, 16);
            this._dataInputPanel.Name = "_dataInputPanel";
            this._dataInputPanel.RowCount = 7;
            this._dataInputPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._dataInputPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._dataInputPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._dataInputPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._dataInputPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._dataInputPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._dataInputPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._dataInputPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._dataInputPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this._dataInputPanel.Size = new System.Drawing.Size(153, 263);
            this._dataInputPanel.TabIndex = 0;
            // 
            // _headFullName
            // 
            this._headFullName.Dock = System.Windows.Forms.DockStyle.Fill;
            this._headFullName.Location = new System.Drawing.Point(3, 89);
            this._headFullName.Name = "_headFullName";
            this._headFullName.Size = new System.Drawing.Size(147, 20);
            this._headFullName.TabIndex = 9;
            // 
            // _teachersCount
            // 
            this._teachersCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this._teachersCount.Location = new System.Drawing.Point(3, 145);
            this._teachersCount.Name = "_teachersCount";
            this._teachersCount.Size = new System.Drawing.Size(147, 20);
            this._teachersCount.TabIndex = 8;
            // 
            // _address
            // 
            this._address.Dock = System.Windows.Forms.DockStyle.Fill;
            this._address.Location = new System.Drawing.Point(3, 201);
            this._address.Name = "_address";
            this._address.Size = new System.Drawing.Size(147, 20);
            this._address.TabIndex = 10;
            // 
            // _addData
            // 
            this._addData.Dock = System.Windows.Forms.DockStyle.Fill;
            this._addData.Location = new System.Drawing.Point(5, 229);
            this._addData.Margin = new System.Windows.Forms.Padding(5);
            this._addData.Name = "_addData";
            this._addData.Size = new System.Drawing.Size(143, 29);
            this._addData.TabIndex = 0;
            this._addData.Text = "Добавить";
            this._addData.UseVisualStyleBackColor = true;
            this._addData.Click += new System.EventHandler(this.OnAddDataClicked);
            // 
            // _toolBar
            // 
            this._toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this._actionsMenu, this._helpMenuItem, this._exitMenuItem });
            this._toolBar.Location = new System.Drawing.Point(0, 0);
            this._toolBar.Name = "_toolBar";
            this._toolBar.Size = new System.Drawing.Size(695, 27);
            this._toolBar.TabIndex = 7;
            this._toolBar.Text = "_toolBar";
            // 
            // DepartmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 443);
            this.Controls.Add(this._request);
            this.Controls.Add(this._dataGridsPanel);
            this.Controls.Add(this._dataInput);
            this.Controls.Add(this._toolBar);
            this.Name = "DepartmentsForm";
            this.Text = "Перечень кафедр";
            this.Load += new System.EventHandler(this.OnFormLoaded);
            ((System.ComponentModel.ISupportInitialize)(this._dataGrid)).EndInit();
            this._requestPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._requestContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._sampleGrid)).EndInit();
            this._sample.ResumeLayout(false);
            this._data.ResumeLayout(false);
            this._request.ResumeLayout(false);
            this._dataGridsPanel.ResumeLayout(false);
            this._dataInput.ResumeLayout(false);
            this._dataInputPanel.ResumeLayout(false);
            this._dataInputPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._teachersCount)).EndInit();
            this._toolBar.ResumeLayout(false);
            this._toolBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button _search;
        private System.Windows.Forms.NumericUpDown _requestContent;
        private System.Windows.Forms.TextBox _address;
        private System.Windows.Forms.TextBox _headFullName;
        private System.Windows.Forms.NumericUpDown _teachersCount;
        private System.Windows.Forms.DataGridView _dataGrid;
        private System.Windows.Forms.Label _departmentNameLabel;
        private System.Windows.Forms.TextBox _departmentName;
        private System.Windows.Forms.Label _headFullNameLabel;
        private System.Windows.Forms.Label _teachersCountLabel;
        private System.Windows.Forms.TableLayoutPanel _requestPanel;
        private System.Windows.Forms.RadioButton _teachersCountRequest;
        private System.Windows.Forms.DataGridView _sampleGrid;
        private System.Windows.Forms.GroupBox _sample;
        private System.Windows.Forms.GroupBox _data;
        private System.Windows.Forms.GroupBox _request;
        private System.Windows.Forms.TableLayoutPanel _dataGridsPanel;
        private System.Windows.Forms.ToolStripMenuItem _helpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _searchMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _addDataMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _actionsMenu;
        private System.Windows.Forms.Label _addressLabel;
        private System.Windows.Forms.ToolStripMenuItem _exitMenuItem;
        private System.Windows.Forms.GroupBox _dataInput;
        private System.Windows.Forms.TableLayoutPanel _dataInputPanel;
        private System.Windows.Forms.Button _addData;
        private System.Windows.Forms.MenuStrip _toolBar;

        #endregion
    }
}