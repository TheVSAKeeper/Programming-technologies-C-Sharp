using System.ComponentModel;

namespace Structures
{
    partial class MainForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._departmentsStart = new System.Windows.Forms.Button();
            this._departmentsHelp = new System.Windows.Forms.Button();
            this._departmentsLabel = new System.Windows.Forms.Label();
            this._employeesHelp = new System.Windows.Forms.Button();
            this._employeesStart = new System.Windows.Forms.Button();
            this._employeesLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this._departmentsStart, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this._departmentsHelp, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this._departmentsLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this._employeesHelp, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this._employeesStart, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this._employeesLabel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(322, 152);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // _departmentsStart
            // 
            this._departmentsStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this._departmentsStart.Location = new System.Drawing.Point(167, 118);
            this._departmentsStart.Margin = new System.Windows.Forms.Padding(5);
            this._departmentsStart.Name = "_departmentsStart";
            this._departmentsStart.Size = new System.Drawing.Size(148, 27);
            this._departmentsStart.TabIndex = 6;
            this._departmentsStart.Text = "Запустить";
            this._departmentsStart.UseVisualStyleBackColor = true;
            this._departmentsStart.Click += new System.EventHandler(this.OnDepartmentsStartClicked);
            // 
            // _departmentsHelp
            // 
            this._departmentsHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this._departmentsHelp.Location = new System.Drawing.Point(167, 81);
            this._departmentsHelp.Margin = new System.Windows.Forms.Padding(5);
            this._departmentsHelp.Name = "_departmentsHelp";
            this._departmentsHelp.Size = new System.Drawing.Size(148, 25);
            this._departmentsHelp.TabIndex = 5;
            this._departmentsHelp.Text = "Справка";
            this._departmentsHelp.UseVisualStyleBackColor = true;
            this._departmentsHelp.Click += new System.EventHandler(this.OnDepartmentsHelpClicked);
            // 
            // _departmentsLabel
            // 
            this._departmentsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._departmentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._departmentsLabel.Location = new System.Drawing.Point(2, 81);
            this._departmentsLabel.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this._departmentsLabel.Name = "_departmentsLabel";
            this.tableLayoutPanel1.SetRowSpan(this._departmentsLabel, 2);
            this._departmentsLabel.Size = new System.Drawing.Size(158, 64);
            this._departmentsLabel.TabIndex = 4;
            this._departmentsLabel.Text = "Перечень кафедр";
            this._departmentsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _employeesHelp
            // 
            this._employeesHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this._employeesHelp.Location = new System.Drawing.Point(167, 7);
            this._employeesHelp.Margin = new System.Windows.Forms.Padding(5);
            this._employeesHelp.Name = "_employeesHelp";
            this._employeesHelp.Size = new System.Drawing.Size(148, 25);
            this._employeesHelp.TabIndex = 3;
            this._employeesHelp.Text = "Справка";
            this._employeesHelp.UseVisualStyleBackColor = true;
            this._employeesHelp.Click += new System.EventHandler(this.OnEmployeesHelpClicked);
            // 
            // _employeesStart
            // 
            this._employeesStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this._employeesStart.Location = new System.Drawing.Point(167, 44);
            this._employeesStart.Margin = new System.Windows.Forms.Padding(5);
            this._employeesStart.Name = "_employeesStart";
            this._employeesStart.Size = new System.Drawing.Size(148, 25);
            this._employeesStart.TabIndex = 0;
            this._employeesStart.Text = "Запустить";
            this._employeesStart.UseVisualStyleBackColor = true;
            this._employeesStart.Click += new System.EventHandler(this.OnEmployeesStartClicked);
            // 
            // _employeesLabel
            // 
            this._employeesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._employeesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._employeesLabel.Location = new System.Drawing.Point(2, 7);
            this._employeesLabel.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this._employeesLabel.Name = "_employeesLabel";
            this.tableLayoutPanel1.SetRowSpan(this._employeesLabel, 2);
            this._employeesLabel.Size = new System.Drawing.Size(158, 62);
            this._employeesLabel.TabIndex = 2;
            this._employeesLabel.Text = "Отдел кадров";
            this._employeesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 152);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Работа со структурами";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button _departmentsHelp;
        private System.Windows.Forms.Button _departmentsStart;
        private System.Windows.Forms.Label _departmentsLabel;
        private System.Windows.Forms.Button _employeesHelp;
        private System.Windows.Forms.Button _employeesStart;
        private System.Windows.Forms.Label _employeesLabel;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        #endregion
    }
}