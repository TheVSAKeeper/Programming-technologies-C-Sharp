using System;
using System.Windows.Forms;
using Structures.Departments;
using Structures.Employees;
using Structures.Help;

namespace Structures
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OnEmployeesStartClicked(object sender, EventArgs e)
        {
            LoadForm(new EmployeesForm(), sender as Control);
        }

        private void OnEmployeesHelpClicked(object sender, EventArgs e)
        {
            LoadForm(new HelpForm("Help/EmployeesHelp.rtf"), sender as Control);
        }

        private void OnDepartmentsStartClicked(object sender, EventArgs e)
        {
            LoadForm(new DepartmentsForm(), sender as Control);
        }

        private void OnDepartmentsHelpClicked(object sender, EventArgs e)
        {
            LoadForm(new HelpForm("Help/DepartmentsHelp.rtf"), sender as Control);
        }

        private static void LoadForm(Form form, Control control)
        {
            if (form == null)
                return;

            form.Show();
            form.FormClosed += (sender, args) => control.Enabled = true;
            control.Enabled = false;
        }
    }
}