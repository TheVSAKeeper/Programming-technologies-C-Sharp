﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Structures.Help;

namespace Structures.Employees
{
    public partial class EmployeesForm : Form
    {
        private readonly List<Employee> _employees = new List<Employee>();

        private readonly List<string> _availableAcademicDegrees = new List<string>();
        private readonly List<string> _availablePosts = new List<string>();

        public EmployeesForm()
        {
            InitializeComponent();
            FillAcademicDegrees();
            FillPosts();
        }

        private void FillAcademicDegrees()
        {
            _availableAcademicDegrees.Add("Без уч. степени");
            _availableAcademicDegrees.Add("Кандидат наук");
            _availableAcademicDegrees.Add("Доктор наук");
        }

        private void FillPosts()
        {
            _availablePosts.Add("Преподаватель");
            _availablePosts.Add("Ст. преподаватель");
            _availablePosts.Add("Доцент");
            _availablePosts.Add("Профессор");
        }

        private void OnFormLoaded(object sender, EventArgs e)
        {
            _birthDate.MaxDate = DateTime.Today;

            foreach (string post in _availablePosts)
                _post.Items.Add(post);

            _post.SelectedIndex = 0;

            foreach (string academicDegree in _availableAcademicDegrees)
                _academicDegree.Items.Add(academicDegree);

            _academicDegree.SelectedIndex = 0;

            AddColumns(_dataGrid);
            AddColumns(_sampleGrid);

            _requestContent.AutoCompleteCustomSource.AddRange(_availablePosts.ToArray());
        }

        private void OnAddDataClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_fullName.Text))
            {
                MessageBox.Show(@"Введите ФИО!", @"Ошибка добавления");
                return;
            }

            Employee employee = new Employee(_fullName.Text,
                _post.Text,
                _birthDate.Value,
                _academicDegree.Text,
                (int)_workExperience.Value);

            _employees.Add(employee);

            AddEmployee(_dataGrid, employee);
        }

        private void OnSearchClicked(object sender, EventArgs e)
        {
            _sampleGrid.Rows.Clear();

            if (_workExperienceRequest.Checked)
                if (int.TryParse(_requestContent.Text, out int workExperience))
                    SearchBy(employee => employee.WorkExperience >= workExperience);

            if (_postRequest.Checked)
                SearchBy(employee => employee.Post == _requestContent.Text);
        }

        private void OnExitClicked(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(@"Вы действительно хотите закрыть приложение?", @"Выход", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
                Close();
        }

        private void OnHelpClicked(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm("Help/EmployeesHelp.rtf");
            helpForm.Show();
        }

        private void SearchBy(Func<Employee, bool> predicate)
        {
            foreach (Employee employee in _employees.Where(predicate))
                AddEmployee(_sampleGrid, employee);
        }

        private static void AddColumns(DataGridView dataGridView)
        {
            dataGridView.Columns.Add("FullName", "ФИО");
            dataGridView.Columns.Add("Post", "Должность");
            dataGridView.Columns.Add("BirthDate", "Дата рождения");
            dataGridView.Columns.Add("AcademicDegree", "Ученая степень");
            dataGridView.Columns.Add("WorkExperience", "Стаж");
        }

        private static void AddEmployee(DataGridView dataGridView, Employee employee)
        {
            dataGridView.Rows.Add(employee.FullName,
                employee.Post,
                employee.BirthDate.ToString("dd.MM.yyyy"),
                employee.AcademicDegree,
                employee.WorkExperience.ToString());

            dataGridView.AutoResizeColumns();
        }
    }
}