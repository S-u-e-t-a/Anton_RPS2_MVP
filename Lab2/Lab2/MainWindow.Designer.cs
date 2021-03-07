namespace Lab2
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxOptions = new System.Windows.Forms.GroupBox();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.comboBoxMode = new System.Windows.Forms.ComboBox();
            this.comboBoxCipher = new System.Windows.Forms.ComboBox();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InputFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveInputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveResToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxOptions.SuspendLayout();
            this.groupBoxResult.SuspendLayout();
            this.groupBoxInput.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxOptions
            // 
            this.groupBoxOptions.Controls.Add(this.ButtonStart);
            this.groupBoxOptions.Controls.Add(this.comboBoxMode);
            this.groupBoxOptions.Controls.Add(this.comboBoxCipher);
            this.groupBoxOptions.Font = new System.Drawing.Font("Noto Sans Cond", 9.749999F, System.Drawing.FontStyle.Bold);
            this.groupBoxOptions.Location = new System.Drawing.Point(12, 163);
            this.groupBoxOptions.Name = "groupBoxOptions";
            this.groupBoxOptions.Size = new System.Drawing.Size(590, 53);
            this.groupBoxOptions.TabIndex = 6;
            this.groupBoxOptions.TabStop = false;
            this.groupBoxOptions.Text = "Настройка";
            // 
            // ButtonStart
            // 
            this.ButtonStart.Location = new System.Drawing.Point(401, 21);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(177, 26);
            this.ButtonStart.TabIndex = 2;
            this.ButtonStart.Text = "Запуск";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click_1);
            // 
            // comboBoxMode
            // 
            this.comboBoxMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMode.FormattingEnabled = true;
            this.comboBoxMode.Items.AddRange(new object[] {
            "Режим работы",
            "Зашифровать",
            "Расшифровать"});
            this.comboBoxMode.Location = new System.Drawing.Point(204, 21);
            this.comboBoxMode.Name = "comboBoxMode";
            this.comboBoxMode.Size = new System.Drawing.Size(177, 26);
            this.comboBoxMode.TabIndex = 1;
            // 
            // comboBoxCipher
            // 
            this.comboBoxCipher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCipher.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxCipher.FormattingEnabled = true;
            this.comboBoxCipher.Items.AddRange(new object[] {
            "Способ шифрования",
            "Атбаш",
            "ROT13"});
            this.comboBoxCipher.Location = new System.Drawing.Point(7, 21);
            this.comboBoxCipher.Name = "comboBoxCipher";
            this.comboBoxCipher.Size = new System.Drawing.Size(177, 26);
            this.comboBoxCipher.TabIndex = 0;
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.textBoxResult);
            this.groupBoxResult.Font = new System.Drawing.Font("Noto Sans Cond", 9.749999F, System.Drawing.FontStyle.Bold);
            this.groupBoxResult.Location = new System.Drawing.Point(12, 222);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(590, 129);
            this.groupBoxResult.TabIndex = 5;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Результат";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(7, 24);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(577, 105);
            this.textBoxResult.TabIndex = 0;
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.textBoxInput);
            this.groupBoxInput.Font = new System.Drawing.Font("Noto Sans Cond", 9.749999F, System.Drawing.FontStyle.Bold);
            this.groupBoxInput.Location = new System.Drawing.Point(12, 27);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(590, 129);
            this.groupBoxInput.TabIndex = 4;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Исходный текст";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(7, 25);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInput.Size = new System.Drawing.Size(577, 98);
            this.textBoxInput.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem,
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(613, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InputFromFileToolStripMenuItem,
            this.SaveInputToolStripMenuItem,
            this.SaveResToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.справкаToolStripMenuItem.Text = "Файл";
            // 
            // InputFromFileToolStripMenuItem
            // 
            this.InputFromFileToolStripMenuItem.Name = "InputFromFileToolStripMenuItem";
            this.InputFromFileToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.InputFromFileToolStripMenuItem.Text = "Ввести текст из файла";
            this.InputFromFileToolStripMenuItem.Click += new System.EventHandler(this.InputFromFileToolStripMenuItem_Click);
            // 
            // SaveInputToolStripMenuItem
            // 
            this.SaveInputToolStripMenuItem.Enabled = false;
            this.SaveInputToolStripMenuItem.Name = "SaveInputToolStripMenuItem";
            this.SaveInputToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.SaveInputToolStripMenuItem.Text = "Сохранить исходный текст";
            this.SaveInputToolStripMenuItem.Click += new System.EventHandler(this.SaveInputToolStripMenuItem_Click);
            // 
            // SaveResToolStripMenuItem
            // 
            this.SaveResToolStripMenuItem.Enabled = false;
            this.SaveResToolStripMenuItem.Name = "SaveResToolStripMenuItem";
            this.SaveResToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.SaveResToolStripMenuItem.Text = "Сохранить результаты";
            this.SaveResToolStripMenuItem.Click += new System.EventHandler(this.SaveResToolStripMenuItem_Click);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.файлToolStripMenuItem.Text = "Справка";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 369);
            this.Controls.Add(this.groupBoxOptions);
            this.Controls.Add(this.groupBoxResult);
            this.Controls.Add(this.groupBoxInput);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Шифрование текста";
            this.groupBoxOptions.ResumeLayout(false);
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxResult.PerformLayout();
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxOptions;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.ComboBox comboBoxMode;
        private System.Windows.Forms.ComboBox comboBoxCipher;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InputFromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveInputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveResToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

