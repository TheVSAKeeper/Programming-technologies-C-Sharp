using System;
using System.Windows.Forms;

namespace TextFiles
{
    partial class MainForm
    {
        private const Keys KeySelectNextSentence = Keys.N;
        private int _currentSentenceIndex;
        private int[] _sentenceIndexes;
        private int[] _sentenceLengths;

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData != (Keys.Control | KeySelectNextSentence))
                return base.ProcessCmdKey(ref msg, keyData);

            SelectNextSentence();
            return true;
        }

        private void OnTextChanged(object sender, EventArgs e)
        {
            _sentenceIndexes = null;
            _sentenceLengths = null;
            _currentSentenceIndex = 0;
        }

        private void SelectNextSentence()
        {
            if (_text.Text.Length == 0)
                return;

            if (_sentenceIndexes == null || _sentenceLengths == null)
                FillSentences(_text.Text, out _sentenceIndexes, out _sentenceLengths);

            if (_sentenceIndexes.Length == 0 || _sentenceLengths.Length == 0)
                return;

            if (_currentSentenceIndex == _sentenceIndexes.Length)
                _currentSentenceIndex = 0;

            int start = _sentenceIndexes[_currentSentenceIndex];
            int length = _sentenceLengths[_currentSentenceIndex];
            _text.Select(start, length);

            _currentSentenceIndex++;
        }

        private static void FillSentences(string text, out int[] sentenceIndexes, out int[] sentenceLengths)
        {
            int[] endIndexes = IndexesOf(text, '.');
            sentenceIndexes = IndexesOfSentenceStart(endIndexes);
            sentenceLengths = CalculateSentencesLengths(sentenceIndexes, endIndexes);

            Mix(sentenceIndexes);
            Mix(sentenceLengths);
        }

        private static int[] CalculateSentencesLengths(int[] startIndexes, int[] endIndexes)
        {
            int[] lengths = new int[startIndexes.Length];

            for (int i = 0; i < endIndexes.Length; i++)
                lengths[i] = endIndexes[i] - startIndexes[i] + 1;

            return lengths;
        }

        private static int[] IndexesOfSentenceStart(int[] endIndexes)
        {
            int[] indexes = new int[endIndexes.Length];

            for (int i = 1; i < endIndexes.Length; i++)
                indexes[i] = endIndexes[i - 1] + 1;

            return indexes;
        }

        private static void Mix(int[] indexes)
        {
            for (int i = 0; i < indexes.Length - 1; i += 3)
                Swap(ref indexes[i + 1], ref indexes[i]);
        }

        private static void Swap(ref int x, ref int y)
        {
            (x, y) = (y, x);
        }

        private static int[] IndexesOf(string text, char symbol)
        {
            int[] indexes = new int[CountOf(text, symbol)];
            int index = 0;

            for (int i = 0; i < text.Length; i++)
                if (text[i] == symbol)
                    indexes[index++] = i;

            return indexes;
        }

        private static int CountOf(string text, char symbol)
        {
            int count = 0;

            for (int i = 0; i < text.Length; i++)
                if (text[i] == symbol)
                    count++;

            return count;
        }
    }
}