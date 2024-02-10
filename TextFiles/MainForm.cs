using System;
using System.Windows.Forms;

namespace TextFiles
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OnStart(object sender, EventArgs e)
        {
            _text.ContextMenu = CreateFileMenu();
        }

        private void Debug(string message)
        {
            _information.Text += message;
        }
    }
}