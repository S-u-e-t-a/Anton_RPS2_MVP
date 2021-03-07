using System.Windows.Forms;
using Lab2.Views;
using Lab2.Presenters;
using System;
using System.IO;

namespace Lab2
{
    public partial class MainWindow : Form, ICipherAlgs
    {

        public MainWindow()
        {
            InitializeComponent();
            MaximizeBox = false;
            saveFileDialog.Filter = @"Text files(*.txt)|*.txt"; // фильтр файлов при сохранении 
            comboBoxCipher.SelectedIndex = 0;
            comboBoxMode.SelectedIndex = 0;
        }

        public string InputText
        {
            get => textBoxInput.Text;
            set => textBoxInput.Text = value;
        }

        public string ResultText
        {
            get => textBoxResult.Text;
            set => textBoxResult.Text = value;
        }

        public string Path { get; set; }

        private void ButtonStart_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(InputText))
            {
                if (comboBoxCipher.Text == @"Атбаш" && comboBoxMode.Text == @"Зашифровать")
                {
                    var presenter = new CipherPresenter(this);
                    presenter.EncodeAtbash();
                }

                if (comboBoxCipher.Text == @"Атбаш" && comboBoxMode.Text == @"Расшифровать")
                {
                    var presenter = new CipherPresenter(this);
                    presenter.DecodeAtbash();
                }

                if (comboBoxCipher.Text == @"ROT13" && comboBoxMode.Text == @"Зашифровать")
                {
                    var presenter = new CipherPresenter(this);
                    presenter.EncodeRot13();
                }

                if (comboBoxCipher.Text == @"ROT13" && comboBoxMode.Text == @"Расшифровать")
                {
                    var presenter = new CipherPresenter(this);
                    presenter.DecodeRot13();
                }
            }
            else if (string.IsNullOrEmpty(InputText))
            {
                MessageBox.Show(@"Вы ввели пустую строку. Попробуйте еще раз.",
                    @"Внимание",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            if (!string.IsNullOrEmpty(InputText))
            {
                SaveInputToolStripMenuItem.Enabled = true;
            }

            if (!string.IsNullOrEmpty(ResultText))
            {
                SaveResToolStripMenuItem.Enabled = true;
            }
        }

        private void InputFromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                Path = string.Empty;
                return; // обработка закрытия окна выбора файла
            }
            Path = openFileDialog.FileName;
            InputText = File.ReadAllText(Path);
            Path = string.Empty;
        }
        private void SaveInputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            Path = saveFileDialog.FileName;
            var presenter = new CipherPresenter(this);
            presenter.SaveInput();
            Path = string.Empty;

        }
        private void SaveResToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            Path = saveFileDialog.FileName;
            var presenter = new CipherPresenter(this);
            presenter.SaveResult();
            Path = string.Empty;
        }
    }
}
