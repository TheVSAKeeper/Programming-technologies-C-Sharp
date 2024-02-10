using System;
using System.IO;
using System.Windows.Forms;

namespace BinaryTrees.Help
{
    public partial class HelpForm : Form
    {
        private readonly string _helpPath;

        public HelpForm(string helpPath)
        {
            InitializeComponent();

            _helpPath = helpPath;
        }

        protected override void OnShown(EventArgs e)
        {
            if (File.Exists(_helpPath) == false)
            {
                MessageBox.Show(@"Файл со справкой отсутствует", @"Ошибка", MessageBoxButtons.OK);
                Close();
                return;
            }

            _helpContent.LoadFile(_helpPath);
            base.OnShown(e);
        }
    }
}