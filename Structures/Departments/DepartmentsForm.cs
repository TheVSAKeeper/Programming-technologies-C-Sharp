using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Structures.Help;

namespace Structures.Departments
{
    public partial class DepartmentsForm : Form
    {
        private readonly List<Department> _departments = new List<Department>();

        public DepartmentsForm()
        {
            InitializeComponent();
        }

        private void OnFormLoaded(object sender, EventArgs e)
        {
            AddColumns(_dataGrid);
            AddColumns(_sampleGrid);
        }

        private void OnAddDataClicked(object sender, EventArgs e)
        {
            List<string> text = new List<string>();

            if (string.IsNullOrWhiteSpace(_departmentName.Text))
                text.Add(_departmentNameLabel.Text);

            if (string.IsNullOrWhiteSpace(_headFullName.Text))
                text.Add(_headFullNameLabel.Text);

            if (string.IsNullOrWhiteSpace(_address.Text))
                text.Add(_addressLabel.Text);

            if (text.Count != 0)
            {
                MessageBox.Show($@"Введите {string.Join(", ", text)}!", @"Ошибка добавления");
                return;
            }

            Department department = new Department(_departmentName.Text, _headFullName.Text, (int)_teachersCount.Value, _address.Text);
            _departments.Add(department);
            Add(_dataGrid, department);
        }

        private void OnSearchClicked(object sender, EventArgs e)
        {
            _sampleGrid.Rows.Clear();

            if (_teachersCountRequest.Checked)
                SearchBy(department => department.TeachersCount >= _requestContent.Value);
        }

        private void OnExitClicked(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(@"Вы действительно хотите закрыть приложение?", @"Выход", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
                Close();
        }

        private void OnHelpClicked(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm("Help/DepartmentsHelp.rtf");
            helpForm.Show();
        }

        private void SearchBy(Func<Department, bool> predicate)
        {
            foreach (Department department in _departments.Where(predicate))
                Add(_sampleGrid, department);
        }

        private static void AddColumns(DataGridView dataGridView)
        {
            dataGridView.Columns.Add("Name", "Название кафедры");
            dataGridView.Columns.Add("HeadFullName", "ФИО зав. кафедрой");
            dataGridView.Columns.Add("TeachersCount", "Кол-во преподавателей");
            dataGridView.Columns.Add("Address", "Адрес");
        }

        private static void Add(DataGridView dataGridView, Department department)
        {
            dataGridView.Rows.Add(department.Name, department.HeadFullName, department.TeachersCount, department.Address);
            dataGridView.AutoResizeColumns();
        }
    }
}