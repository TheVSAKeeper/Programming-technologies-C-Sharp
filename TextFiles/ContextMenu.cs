using System;
using System.IO;
using System.Windows.Forms;

namespace TextFiles
{
    partial class MainForm
    {
        private const string TextFileFilter = "Текстовые файлы (*.rtf; *.txt) | *.rtf; *.txt";
        private string SavedFilePath { get; set; }

        private ContextMenu CreateFileMenu()
        {
            ContextMenu menu = new ContextMenu();

            MenuItem open = new MenuItem { Index = 0, Text = @"Открыть" };
            MenuItem save = new MenuItem { Index = 1, Text = @"Сохранить" };
            MenuItem saveAs = new MenuItem { Index = 2, Text = @"Сохранить как" };

            menu.MenuItems.AddRange(new[] { open, save, saveAs });

            open.Click += OnOpenClicked;
            save.Click += OnSaveClicked;
            saveAs.Click += OnSaveAsClicked;
            return menu;
        }

        private void OnOpenClicked(object sender, EventArgs e)
        {
            SavedFilePath = ReadFile(openFileDialog1, _text);
        }

        private void OnSaveClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SavedFilePath) == false)
            {
                if (SavedFilePath.EndsWith("rtf"))
                    _text.SaveFile(SavedFilePath);
                else if (SavedFilePath.EndsWith("txt"))
                    File.WriteAllText(SavedFilePath, _text.Text);
                else
                    throw new NotImplementedException();

                return;
            }

            SavedFilePath = SaveFile(_saveFileDialog, _text);
        }

        private void OnSaveAsClicked(object sender, EventArgs e)
        {
            SavedFilePath = SaveFile(_saveFileDialog, _text);
        }

        private static string ReadFile(FileDialog fileDialog, RichTextBox richTextBox)
        {
            fileDialog.Filter = TextFileFilter;

            if (fileDialog.ShowDialog() != DialogResult.OK)
                return null;

            string openedFilePath = fileDialog.FileName;

            if (openedFilePath.EndsWith("rtf"))
                richTextBox.LoadFile(openedFilePath);
            else if (openedFilePath.EndsWith("txt"))
                richTextBox.Text = File.ReadAllText(openedFilePath);
            else
                throw new NotImplementedException();

            return openedFilePath;
        }

        private static string SaveFile(FileDialog fileDialog, RichTextBox richTextBox)
        {
            fileDialog.Filter = TextFileFilter;

            if (fileDialog.ShowDialog() != DialogResult.OK)
                return null;

            string savedFilePath = fileDialog.FileName;

            if (savedFilePath.EndsWith("rtf"))
                richTextBox.SaveFile(savedFilePath);
            else if (savedFilePath.EndsWith("txt"))
                File.WriteAllText(savedFilePath, richTextBox.Text);
            else
                throw new NotImplementedException();

            return savedFilePath;
        }
    }
}