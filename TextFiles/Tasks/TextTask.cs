using System;
using System.Drawing;
using System.Windows.Forms;

namespace TextFiles
{
    public partial class MainForm
    {
        private int _firstWordIndex = -1;
        private int _secondWordIndex = -1;

        private bool IsFirstWordFound => _firstWordIndex >= 0;
        private bool IsSecondWordFound => _secondWordIndex >= 0;

        private void OnResetClicked(object sender, EventArgs e)
        {
            _information.Clear();
            _secondWord.Clear();
            _firstWord.Clear();
            _text.Clear();

            _firstWordIndex = -1;
            _secondWordIndex = -1;

            _findFirstButton.TurnOn();
            _findSecondWordButton.TurnOn();
            _swapButton.TurnOn();
        }

        private void OnFirstWordSearchClicked(object sender, EventArgs e)
        {
            Debug($@"Поиск первого слова {Environment.NewLine}");

            string firstWord = _firstWord.Text;
            int firstWordIndex = _text.Text.IndexOf(firstWord, StringComparison.Ordinal);

            if (firstWordIndex == -1)
            {
                Debug($@"Слово не найдено {Environment.NewLine}{Environment.NewLine}");
                return;
            }

            Debug($@"Позиция первого слова: {firstWordIndex + 1}{Environment.NewLine}{Environment.NewLine}");

            SelectWord(_text, firstWord, firstWordIndex, Color.Red);

            _findFirstButton.TurnOff();
            _firstWordIndex = firstWordIndex;
        }

        private void OnSecondWordSearchClicked(object sender, EventArgs e)
        {
            Debug($@"Поиск второго слова {Environment.NewLine}");

            string secondWord = _secondWord.Text;
            _secondWordIndex = IndexOfWord(_text.Text, secondWord);

            if (_secondWordIndex == -1)
            {
                Debug($@"Слово не найдено {Environment.NewLine}{Environment.NewLine}");
                return;
            }

            Debug($@"Позиция второго слова: {_secondWordIndex + 1}{Environment.NewLine}{Environment.NewLine}");

            SelectWord(_text, secondWord, _secondWordIndex, Color.Green);

            _findSecondWordButton.TurnOff();
        }

        private void OnSwapClicked(object sender, EventArgs e)
        {
            if (IsFirstWordFound == false || IsSecondWordFound == false)
                return;

            if (_firstWordIndex < _secondWordIndex)
            {
                _text.Select(_secondWordIndex, _secondWord.Text.Length);
                _text.SelectedText = _firstWord.Text;

                _text.Select(_firstWordIndex, _firstWord.Text.Length);
                _text.SelectedText = _secondWord.Text;
            }
            else
            {
                _text.Select(_firstWordIndex, _firstWord.Text.Length);
                _text.SelectedText = _secondWord.Text;

                _text.Select(_secondWordIndex, _secondWord.Text.Length);
                _text.SelectedText = _firstWord.Text;
            }

            Debug(@"Произошла замена слов");
            _swapButton.TurnOff();
        }

        private static void SelectWord(RichTextBox richTextBox, string word, int index, Color color)
        {
            richTextBox.SelectionStart = index;
            richTextBox.SelectionLength = word.Length;
            richTextBox.SelectionBackColor = color;
        }

        private static int IndexOfWord(string text, string word)
        {
            for (int i = 0; i <= text.Length - word.Length; i++)
            {
                string substring = text.Substring(i, word.Length);

                if (substring == word)
                    return i;
            }

            return -1;
        }
    }
}