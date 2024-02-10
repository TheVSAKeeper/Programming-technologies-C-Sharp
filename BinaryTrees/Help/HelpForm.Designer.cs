using System.ComponentModel;

namespace BinaryTrees.Help
{
    partial class HelpForm
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
            this._helpContent = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // _helpContent
            // 
            this._helpContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this._helpContent.Location = new System.Drawing.Point(0, 0);
            this._helpContent.Name = "_helpContent";
            this._helpContent.ReadOnly = true;
            this._helpContent.Size = new System.Drawing.Size(518, 321);
            this._helpContent.TabIndex = 0;
            this._helpContent.Text = "";
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 321);
            this.Controls.Add(this._helpContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "HelpForm";
            this.Text = "Справка";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.RichTextBox _helpContent;

        #endregion
    }
}