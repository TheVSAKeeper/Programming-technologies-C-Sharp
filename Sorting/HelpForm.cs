using System;
using System.IO;
using System.Windows.Forms;

namespace Sorting
{
    public partial class HelpForm : Form
    {
        private const string HelpPath = "Help.rtf";

        public HelpForm()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            if (File.Exists(HelpPath) == false)
            {
                MessageBox.Show(@"Файл со справкой отсутствует", @"Ошибка", MessageBoxButtons.OK);
                Close();
                return;
            }

            _helpContent.LoadFile(HelpPath);
            base.OnShown(e);
        }
    }
}