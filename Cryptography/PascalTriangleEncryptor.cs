using System;

namespace Cryptography
{
    public class PascalTriangleEncryptor
    {
        private readonly char[] _separators = { '_', ' ' };
        private int[][] _triangle;

        public PascalTriangleEncryptor()
        {
            _triangle = CreateTriangle(1);
        }

        private static int[][] CreateTriangle(int rowsCount)
        {
            int[][] triangle = new int[rowsCount][];

            for (int i = 0; i < rowsCount; i++)
            {
                triangle[i] = new int[i + 1];

                triangle[i][0] = 1;
                triangle[i][i] = 1;

                for (int j = 1; j < i; j++)
                    triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
            }

            return triangle;
        }

        public string Decrypt(string encryptedText) => ApplyShift(encryptedText, (row, j) => -row[row.Length - 1 - j]);

        public string Encrypt(string text) => ApplyShift(text, (row, j) => row[j]);

        private string ApplyShift(string text, Func<int[], int, int> getShift)
        {
            string result = string.Empty;
            string[] words = text.Split(_separators);

            foreach (string word in words)
            {
                for (int j = 0; j < word.Length; j++)
                {
                    if (word.Length > _triangle.Length)
                        _triangle = CreateTriangle(word.Length);

                    int shift = getShift(_triangle[word.Length - 1], j);
                    char oldCharacter = word[j];

                    char newCharacter = (char)(oldCharacter + shift);
                    result += newCharacter;
                }

                result += " ";
            }

            return result;
        }
    }
}