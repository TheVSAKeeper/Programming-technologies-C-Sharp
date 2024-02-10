using System;
using System.Windows.Forms;
using Cryptography.Help;

namespace Cryptography
{
    public partial class MainForm : Form
    {
        private readonly PascalTriangleEncryptor _pascalTriangleEncryptor;

        public MainForm()
        {
            _pascalTriangleEncryptor = new PascalTriangleEncryptor();
            InitializeComponent();
        }

        private void OnFormLoaded(object sender, EventArgs e)
        {
            FileContextMenu contextMenu = new FileContextMenu(_inputField, _saveFileDialog, _openFileDialog);
            _inputField.ContextMenu = contextMenu.CreateFileMenu();

            MenuItem encryptMenuItem = new MenuItem("Зашифровать");
            MenuItem decryptMenuItem = new MenuItem("Расшифровать");

            encryptMenuItem.Click += OnEncryptClicked;
            decryptMenuItem.Click += OnDecryptClicked;

            _inputField.ContextMenu.MenuItems.Add(encryptMenuItem);
            _inputField.ContextMenu.MenuItems.Add(decryptMenuItem);
        }

        private void OnEncryptClicked(object sender, EventArgs e)
        {
            string decryptedText = _inputField.Text;
            string encryptedText = _pascalTriangleEncryptor.Encrypt(decryptedText);

            _inputField.Text = encryptedText;
        }

        private void OnDecryptClicked(object sender, EventArgs e)
        {
            string encryptedText = _inputField.Text;
            string decryptedText = _pascalTriangleEncryptor.Decrypt(encryptedText);

            _inputField.Text = decryptedText;
        }

        private void OnCloseClicked(object sender, EventArgs e)
        {
            Close();
        }

        private void OnHelpClicked(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm("Help/Help.rtf");
            helpForm.Show();
        }
    }
}