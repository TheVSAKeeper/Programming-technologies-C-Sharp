using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using BinaryTrees.Help;
using BinaryTrees.Search;

namespace BinaryTrees
{
    public partial class MainForm : Form
    {
        private BinaryTree _binaryTree;

        public MainForm()
        {
            InitializeComponent();
            AddSearchItems(_performSearchMenu.DropDownItems);
        }

        private void OnLoadClicked(object sender, EventArgs e)
        {
            _performSearchMenu.Enabled = true;
            _textBoxTree.Clear();
            _textBoxBypass.Clear();
            _textBoxSearch.Clear();

            if (_treeRequestDialog.ShowDialog() != DialogResult.OK)
                return;

            Queue<int> values;

            if (_binarySearchTreeButton.Checked)
            {
                _binaryTree = new BinarySearchTree();
                values = GetNumbers();
            }
            else
            {
                _binaryTree = new SelfBalancingBinarySearchTree();
                values = GetCharacters();
            }

            _binaryTree.AddNodes(values);
            _binaryTree.FillTreeView(_treeView);

            _treeView.ExpandAll();

            _textBoxTree.Text = _binaryTree.GetDescription();
        }

        private void OnHelpClicked(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm("Help/Help.rtf");
            helpForm.Show();
        }

        private void OnCloseClicked(object sender, EventArgs e)
        {
            Close();
        }

        private void AddSearchItems(ToolStripItemCollection searchItems)
        {
            foreach (SearchType type in Enum.GetValues(typeof(SearchType)))
            {
                ToolStripMenuItem item = new ToolStripMenuItem(SearchMethods.GetDescription(type));
                item.Click += (o, args) => AddSearchType(type);
                searchItems.Add(item);
            }

            ToolStripMenuItem allItem = new ToolStripMenuItem("Все");

            allItem.Click += (sender, args) =>
            {
                foreach (ToolStripItem dropDownItem in searchItems)
                    if (dropDownItem != allItem)
                        dropDownItem.PerformClick();
            };

            searchItems.Add(allItem);
        }

        private void AddSearchType(SearchType type)
        {
            string searchResult = _binaryTree.PerformBypass(type);
            _textBoxBypass.AppendText($"{SearchMethods.GetDescription(type)}: {searchResult}{Environment.NewLine}{Environment.NewLine}");
        }

        private Queue<int> GetNumbers()
        {
            Queue<int> values = new Queue<int>();
            string[] lines = File.ReadAllLines(_treeRequestDialog.FileName);

            foreach (string line in lines)
            {
                if (int.TryParse(line, out int result) == false)
                {
                    MessageBox.Show(@"Ошибка ввода", @"Графы", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    return values;
                }

                values.Enqueue(result);
            }

            return values;
        }

        private Queue<int> GetCharacters()
        {
            Queue<int> values = new Queue<int>();
            string text = File.ReadAllText(_treeRequestDialog.FileName);

            foreach (char character in text)
                values.Enqueue(character);

            return values;
        }

        private void OnSearchClicked(object sender, EventArgs e)
        {
            int.TryParse(textBoxKey.Text, out int key);
            string results = _binaryTree.SearchKey(key, out int depth);

            if (string.IsNullOrEmpty(results))
                _textBoxSearch.Text += $@"Элемент {key} не найден{Environment.NewLine}";
            else
                _textBoxSearch.Text += $@"Найден элемент {results} на уровне {depth}{Environment.NewLine}";
        }
    }
}