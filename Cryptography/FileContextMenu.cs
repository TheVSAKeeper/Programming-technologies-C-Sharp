using System;
using System.IO;
using System.Windows.Forms;

namespace Cryptography
{
    public class FileContextMenu
    {
        private const string TextFileFilter = "Текстовые файлы (*.txt) | *.txt";
        private readonly FileDialog _openFileDialog;
        private readonly FileDialog _saveFileDialog;
        private readonly TextBox _text;

        public FileContextMenu(TextBox text, FileDialog saveFileDialog, FileDialog openFileDialog)
        {
            _text = text;
            _saveFileDialog = saveFileDialog;
            _openFileDialog = openFileDialog;
        }

        private string SavedFilePath { get; set; }

        public ContextMenu CreateFileMenu()
        {
            MenuItem open = new MenuItem(@"Открыть");
            MenuItem save = new MenuItem(@"Сохранить");
            MenuItem saveAs = new MenuItem(@"Сохранить как");

            ContextMenu menu = new ContextMenu(new[] { open, save, saveAs });

            open.Click += OnOpenClicked;
            save.Click += OnSaveClicked;
            saveAs.Click += OnSaveAsClicked;

            return menu;
        }

        private void OnOpenClicked(object sender, EventArgs e)
        {
            SavedFilePath = ReadFile(_openFileDialog, _text);
        }

        private void OnSaveClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SavedFilePath) == false)
            {
                File.WriteAllText(SavedFilePath, _text.Text);
                return;
            }

            SavedFilePath = SaveFile(_saveFileDialog, _text);
        }

        private void OnSaveAsClicked(object sender, EventArgs e)
        {
            SavedFilePath = SaveFile(_saveFileDialog, _text);
        }

        private static string ReadFile(FileDialog fileDialog, TextBox textBox)
        {
            fileDialog.Filter = TextFileFilter;

            if (fileDialog.ShowDialog() != DialogResult.OK)
                return null;

            string openedFilePath = fileDialog.FileName;
            textBox.Text = File.ReadAllText(openedFilePath);

            return openedFilePath;
        }

        private static string SaveFile(FileDialog fileDialog, TextBox textBox)
        {
            fileDialog.Filter = TextFileFilter;

            if (fileDialog.ShowDialog() != DialogResult.OK)
                return null;

            string savedFilePath = fileDialog.FileName;
            File.WriteAllText(savedFilePath, textBox.Text);

            return savedFilePath;
        }
    }
}