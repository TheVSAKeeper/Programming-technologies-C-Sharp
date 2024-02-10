namespace TextFiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this._text = new System.Windows.Forms.RichTextBox();
            this._saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this._resetButton = new System.Windows.Forms.Button();
            this._findFirstButton = new System.Windows.Forms.Button();
            this._information = new System.Windows.Forms.TextBox();
            this._secondWord = new System.Windows.Forms.TextBox();
            this._firstWord = new System.Windows.Forms.TextBox();
            this._findSecondWordButton = new System.Windows.Forms.Button();
            this._swapButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _text
            // 
            this._text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this._text.AutoWordSelection = true;
            this._text.EnableAutoDragDrop = true;
            this._text.Location = new System.Drawing.Point(712, 0);
            this._text.Margin = new System.Windows.Forms.Padding(2);
            this._text.Name = "_text";
            this._text.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedHorizontal;
            this._text.Size = new System.Drawing.Size(450, 808);
            this._text.TabIndex = 0;
            this._text.Text = resources.GetString("_text.Text");
            this._text.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // _resetButton
            // 
            this._resetButton.Location = new System.Drawing.Point(469, 11);
            this._resetButton.Margin = new System.Windows.Forms.Padding(16, 2, 16, 2);
            this._resetButton.Name = "_resetButton";
            this._resetButton.Size = new System.Drawing.Size(224, 47);
            this._resetButton.TabIndex = 2;
            this._resetButton.Text = "Сброс";
            this._resetButton.UseVisualStyleBackColor = true;
            this._resetButton.Click += new System.EventHandler(this.OnResetClicked);
            // 
            // _findFirstButton
            // 
            this._findFirstButton.Location = new System.Drawing.Point(469, 308);
            this._findFirstButton.Margin = new System.Windows.Forms.Padding(2);
            this._findFirstButton.Name = "_findFirstButton";
            this._findFirstButton.Size = new System.Drawing.Size(224, 47);
            this._findFirstButton.TabIndex = 3;
            this._findFirstButton.Text = "Найти первое";
            this._findFirstButton.UseVisualStyleBackColor = true;
            this._findFirstButton.Click += new System.EventHandler(this.OnFirstWordSearchClicked);
            // 
            // _information
            // 
            this._information.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this._information.Location = new System.Drawing.Point(0, 0);
            this._information.Margin = new System.Windows.Forms.Padding(2);
            this._information.Multiline = true;
            this._information.Name = "_information";
            this._information.ReadOnly = true;
            this._information.Size = new System.Drawing.Size(450, 808);
            this._information.TabIndex = 4;
            // 
            // _secondWord
            // 
            this._secondWord.Location = new System.Drawing.Point(469, 433);
            this._secondWord.Margin = new System.Windows.Forms.Padding(2);
            this._secondWord.Name = "_secondWord";
            this._secondWord.Size = new System.Drawing.Size(226, 35);
            this._secondWord.TabIndex = 5;
            // 
            // _firstWord
            // 
            this._firstWord.Location = new System.Drawing.Point(469, 265);
            this._firstWord.Margin = new System.Windows.Forms.Padding(2);
            this._firstWord.Name = "_firstWord";
            this._firstWord.Size = new System.Drawing.Size(226, 35);
            this._firstWord.TabIndex = 6;
            // 
            // _findSecondWordButton
            // 
            this._findSecondWordButton.Location = new System.Drawing.Point(469, 473);
            this._findSecondWordButton.Margin = new System.Windows.Forms.Padding(2);
            this._findSecondWordButton.Name = "_findSecondWordButton";
            this._findSecondWordButton.Size = new System.Drawing.Size(224, 47);
            this._findSecondWordButton.TabIndex = 7;
            this._findSecondWordButton.Text = "Найти второе";
            this._findSecondWordButton.UseVisualStyleBackColor = true;
            this._findSecondWordButton.Click += new System.EventHandler(this.OnSecondWordSearchClicked);
            // 
            // _swapButton
            // 
            this._swapButton.Location = new System.Drawing.Point(469, 665);
            this._swapButton.Margin = new System.Windows.Forms.Padding(2);
            this._swapButton.Name = "_swapButton";
            this._swapButton.Size = new System.Drawing.Size(224, 47);
            this._swapButton.TabIndex = 8;
            this._swapButton.Text = "Поменять";
            this._swapButton.UseVisualStyleBackColor = true;
            this._swapButton.Click += new System.EventHandler(this.OnSwapClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 808);
            this.Controls.Add(this._swapButton);
            this.Controls.Add(this._findSecondWordButton);
            this.Controls.Add(this._firstWord);
            this.Controls.Add(this._secondWord);
            this.Controls.Add(this._information);
            this.Controls.Add(this._findFirstButton);
            this.Controls.Add(this._resetButton);
            this.Controls.Add(this._text);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Текстовые файлы, символы и строки";
            this.Load += new System.EventHandler(this.OnStart);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox _firstWord;
        private System.Windows.Forms.Button _findSecondWordButton;
        private System.Windows.Forms.Button _swapButton;

        private System.Windows.Forms.TextBox _information;
        private System.Windows.Forms.TextBox _secondWord;

        private System.Windows.Forms.Button _findFirstButton;

        private System.Windows.Forms.Button _resetButton;

        private System.Windows.Forms.SaveFileDialog _saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;

        private System.Windows.Forms.RichTextBox _text;

        #endregion
    }
}