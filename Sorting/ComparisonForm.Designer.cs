using System.ComponentModel;

namespace Sorting
{
    partial class ComparisonForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this._chartsTable = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._exchangeCountGrid = new System.Windows.Forms.DataGridView();
            this.Length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._comparisionCountLabel = new System.Windows.Forms.Label();
            this._comparisonCountGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._exhangeCountLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this._chartsTable.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._exchangeCountGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._comparisonCountGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // _chartsTable
            // 
            this._chartsTable.ColumnCount = 2;
            this._chartsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._chartsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._chartsTable.Controls.Add(this.tableLayoutPanel1, 1, 1);
            this._chartsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this._chartsTable.Location = new System.Drawing.Point(0, 0);
            this._chartsTable.Margin = new System.Windows.Forms.Padding(6);
            this._chartsTable.Name = "_chartsTable";
            this._chartsTable.RowCount = 2;
            this._chartsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._chartsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._chartsTable.Size = new System.Drawing.Size(2612, 1344);
            this._chartsTable.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this._exchangeCountGrid, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this._comparisionCountLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._comparisonCountGrid, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this._exhangeCountLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1310, 676);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1298, 664);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // _exchangeCountGrid
            // 
            this._exchangeCountGrid.AllowUserToAddRows = false;
            this._exchangeCountGrid.AllowUserToDeleteRows = false;
            this._exchangeCountGrid.AllowUserToResizeColumns = false;
            this._exchangeCountGrid.AllowUserToResizeRows = false;
            this._exchangeCountGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._exchangeCountGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._exchangeCountGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.Length });
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._exchangeCountGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this._exchangeCountGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this._exchangeCountGrid.Location = new System.Drawing.Point(655, 156);
            this._exchangeCountGrid.Margin = new System.Windows.Forms.Padding(6);
            this._exchangeCountGrid.Name = "_exchangeCountGrid";
            this._exchangeCountGrid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._exchangeCountGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this._exchangeCountGrid.RowHeadersVisible = false;
            this._exchangeCountGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this._exchangeCountGrid.Size = new System.Drawing.Size(637, 502);
            this._exchangeCountGrid.TabIndex = 2;
            // 
            // Length
            // 
            this.Length.HeaderText = "Длина";
            this.Length.Name = "Length";
            this.Length.ReadOnly = true;
            // 
            // _comparisionCountLabel
            // 
            this._comparisionCountLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._comparisionCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._comparisionCountLabel.Location = new System.Drawing.Point(6, 0);
            this._comparisionCountLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this._comparisionCountLabel.Name = "_comparisionCountLabel";
            this._comparisionCountLabel.Size = new System.Drawing.Size(637, 60);
            this._comparisionCountLabel.TabIndex = 3;
            this._comparisionCountLabel.Text = "Количество сравнений";
            this._comparisionCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _comparisonCountGrid
            // 
            this._comparisonCountGrid.AllowUserToAddRows = false;
            this._comparisonCountGrid.AllowUserToDeleteRows = false;
            this._comparisonCountGrid.AllowUserToResizeColumns = false;
            this._comparisonCountGrid.AllowUserToResizeRows = false;
            this._comparisonCountGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._comparisonCountGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this._comparisonCountGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.dataGridViewTextBoxColumn1 });
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._comparisonCountGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this._comparisonCountGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this._comparisonCountGrid.Location = new System.Drawing.Point(6, 156);
            this._comparisonCountGrid.Margin = new System.Windows.Forms.Padding(6);
            this._comparisonCountGrid.Name = "_comparisonCountGrid";
            this._comparisonCountGrid.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._comparisonCountGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this._comparisonCountGrid.RowHeadersVisible = false;
            this._comparisonCountGrid.Size = new System.Drawing.Size(637, 502);
            this._comparisonCountGrid.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Длина";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // _exhangeCountLabel
            // 
            this._exhangeCountLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._exhangeCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._exhangeCountLabel.Location = new System.Drawing.Point(655, 0);
            this._exhangeCountLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this._exhangeCountLabel.Name = "_exhangeCountLabel";
            this._exhangeCountLabel.Size = new System.Drawing.Size(637, 60);
            this._exhangeCountLabel.TabIndex = 4;
            this._exhangeCountLabel.Text = "Количество обменов";
            this._exhangeCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(3, 63);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(643, 84);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(652, 63);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(643, 84);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ComparisonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2612, 1344);
            this.Controls.Add(this._chartsTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ComparisonForm";
            this.Text = "Сравнение графиков";
            this._chartsTable.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._exchangeCountGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._comparisonCountGrid)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;

        private System.Windows.Forms.Label _exhangeCountLabel;
        private System.Windows.Forms.Label _comparisionCountLabel;

        private System.Windows.Forms.DataGridView _exchangeCountGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Length;

        private System.Windows.Forms.DataGridView _comparisonCountGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel _chartsTable;

        #endregion
    }
}