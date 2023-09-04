
namespace WindowsFormsApp1
{
    partial class Form1
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
      this.InputTB = new System.Windows.Forms.TextBox();
      this.OutputTB = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.OpenFile = new System.Windows.Forms.Button();
      this.SaveFile = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.PTextBox = new System.Windows.Forms.TextBox();
      this.QTextBox = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.Encrypt = new System.Windows.Forms.Button();
      this.Decrypt = new System.Windows.Forms.Button();
      this.label5 = new System.Windows.Forms.Label();
      this.BTextBox = new System.Windows.Forms.TextBox();
      this.Generate = new System.Windows.Forms.Button();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.Swapbutton = new System.Windows.Forms.Button();
      this.label7 = new System.Windows.Forms.Label();
      this.SizeTB = new System.Windows.Forms.TextBox();
      this.Switch = new System.Windows.Forms.Button();
      this.SwitchLabel = new System.Windows.Forms.Label();
      this.BuferTB = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // InputTB
      // 
      this.InputTB.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.InputTB.Location = new System.Drawing.Point(44, 336);
      this.InputTB.Margin = new System.Windows.Forms.Padding(4);
      this.InputTB.Multiline = true;
      this.InputTB.Name = "InputTB";
      this.InputTB.Size = new System.Drawing.Size(321, 182);
      this.InputTB.TabIndex = 0;
      // 
      // OutputTB
      // 
      this.OutputTB.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.OutputTB.Location = new System.Drawing.Point(427, 336);
      this.OutputTB.Margin = new System.Windows.Forms.Padding(4);
      this.OutputTB.Multiline = true;
      this.OutputTB.Name = "OutputTB";
      this.OutputTB.Size = new System.Drawing.Size(321, 182);
      this.OutputTB.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(39, 306);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(60, 26);
      this.label1.TabIndex = 2;
      this.label1.Text = "Ввод";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label2.Location = new System.Drawing.Point(422, 306);
      this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(75, 26);
      this.label2.TabIndex = 3;
      this.label2.Text = "Вывод";
      // 
      // OpenFile
      // 
      this.OpenFile.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.OpenFile.Location = new System.Drawing.Point(227, 210);
      this.OpenFile.Margin = new System.Windows.Forms.Padding(4);
      this.OpenFile.Name = "OpenFile";
      this.OpenFile.Size = new System.Drawing.Size(177, 52);
      this.OpenFile.TabIndex = 4;
      this.OpenFile.Text = "Открыть файл";
      this.OpenFile.UseVisualStyleBackColor = true;
      this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
      // 
      // SaveFile
      // 
      this.SaveFile.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.SaveFile.Location = new System.Drawing.Point(427, 210);
      this.SaveFile.Margin = new System.Windows.Forms.Padding(4);
      this.SaveFile.Name = "SaveFile";
      this.SaveFile.Size = new System.Drawing.Size(177, 52);
      this.SaveFile.TabIndex = 5;
      this.SaveFile.Text = "Записать в файл";
      this.SaveFile.UseVisualStyleBackColor = true;
      this.SaveFile.Click += new System.EventHandler(this.SaveFile_Click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(16, 11);
      this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(16, 16);
      this.label3.TabIndex = 6;
      this.label3.Text = "P";
      // 
      // PTextBox
      // 
      this.PTextBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.PTextBox.Location = new System.Drawing.Point(29, 11);
      this.PTextBox.Margin = new System.Windows.Forms.Padding(4);
      this.PTextBox.MaxLength = 50;
      this.PTextBox.Multiline = true;
      this.PTextBox.Name = "PTextBox";
      this.PTextBox.Size = new System.Drawing.Size(336, 45);
      this.PTextBox.TabIndex = 7;
      // 
      // QTextBox
      // 
      this.QTextBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.QTextBox.Location = new System.Drawing.Point(29, 64);
      this.QTextBox.Margin = new System.Windows.Forms.Padding(4);
      this.QTextBox.MaxLength = 50;
      this.QTextBox.Multiline = true;
      this.QTextBox.Name = "QTextBox";
      this.QTextBox.Size = new System.Drawing.Size(336, 45);
      this.QTextBox.TabIndex = 8;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(13, 67);
      this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(17, 16);
      this.label4.TabIndex = 9;
      this.label4.Text = "Q";
      // 
      // Encrypt
      // 
      this.Encrypt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Encrypt.Location = new System.Drawing.Point(20, 210);
      this.Encrypt.Margin = new System.Windows.Forms.Padding(4);
      this.Encrypt.Name = "Encrypt";
      this.Encrypt.Size = new System.Drawing.Size(177, 52);
      this.Encrypt.TabIndex = 10;
      this.Encrypt.Text = "Шифровать";
      this.Encrypt.UseVisualStyleBackColor = true;
      this.Encrypt.Click += new System.EventHandler(this.Encrypt_Click);
      // 
      // Decrypt
      // 
      this.Decrypt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Decrypt.Location = new System.Drawing.Point(624, 210);
      this.Decrypt.Margin = new System.Windows.Forms.Padding(4);
      this.Decrypt.Name = "Decrypt";
      this.Decrypt.Size = new System.Drawing.Size(177, 52);
      this.Decrypt.TabIndex = 11;
      this.Decrypt.Text = "Дешифровать";
      this.Decrypt.UseVisualStyleBackColor = true;
      this.Decrypt.Click += new System.EventHandler(this.Decrypt_Click);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(13, 121);
      this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(16, 16);
      this.label5.TabIndex = 12;
      this.label5.Text = "B";
      // 
      // BTextBox
      // 
      this.BTextBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.BTextBox.Location = new System.Drawing.Point(29, 121);
      this.BTextBox.Margin = new System.Windows.Forms.Padding(4);
      this.BTextBox.MaxLength = 50;
      this.BTextBox.Multiline = true;
      this.BTextBox.Name = "BTextBox";
      this.BTextBox.Size = new System.Drawing.Size(336, 46);
      this.BTextBox.TabIndex = 13;
      // 
      // Generate
      // 
      this.Generate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Generate.Location = new System.Drawing.Point(376, 121);
      this.Generate.Margin = new System.Windows.Forms.Padding(4);
      this.Generate.Name = "Generate";
      this.Generate.Size = new System.Drawing.Size(173, 46);
      this.Generate.TabIndex = 14;
      this.Generate.Text = "Ввод";
      this.Generate.UseVisualStyleBackColor = true;
      this.Generate.Click += new System.EventHandler(this.Generate_Click);
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      // 
      // Swapbutton
      // 
      this.Swapbutton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Swapbutton.Location = new System.Drawing.Point(366, 562);
      this.Swapbutton.Margin = new System.Windows.Forms.Padding(4);
      this.Swapbutton.Name = "Swapbutton";
      this.Swapbutton.Size = new System.Drawing.Size(100, 47);
      this.Swapbutton.TabIndex = 16;
      this.Swapbutton.Text = "<--";
      this.Swapbutton.UseVisualStyleBackColor = true;
      this.Swapbutton.Visible = false;
      this.Swapbutton.Click += new System.EventHandler(this.Swapbutton_Click);
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(856, 336);
      this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(85, 16);
      this.label7.TabIndex = 18;
      this.label7.Text = "Байт\\число:";
      this.label7.Visible = false;
      // 
      // SizeTB
      // 
      this.SizeTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.SizeTB.Location = new System.Drawing.Point(860, 356);
      this.SizeTB.Margin = new System.Windows.Forms.Padding(4);
      this.SizeTB.Name = "SizeTB";
      this.SizeTB.Size = new System.Drawing.Size(49, 26);
      this.SizeTB.TabIndex = 19;
      this.SizeTB.Text = "1";
      this.SizeTB.Visible = false;
      // 
      // Switch
      // 
      this.Switch.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Switch.Location = new System.Drawing.Point(376, 11);
      this.Switch.Margin = new System.Windows.Forms.Padding(4);
      this.Switch.Name = "Switch";
      this.Switch.Size = new System.Drawing.Size(100, 39);
      this.Switch.TabIndex = 20;
      this.Switch.Text = "Режим";
      this.Switch.UseVisualStyleBackColor = true;
      this.Switch.Click += new System.EventHandler(this.Switch_Click);
      // 
      // SwitchLabel
      // 
      this.SwitchLabel.AutoSize = true;
      this.SwitchLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.SwitchLabel.Location = new System.Drawing.Point(484, 17);
      this.SwitchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.SwitchLabel.Name = "SwitchLabel";
      this.SwitchLabel.Size = new System.Drawing.Size(62, 26);
      this.SwitchLabel.TabIndex = 21;
      this.SwitchLabel.Text = "Bytes";
      // 
      // BuferTB
      // 
      this.BuferTB.Location = new System.Drawing.Point(860, 439);
      this.BuferTB.Margin = new System.Windows.Forms.Padding(4);
      this.BuferTB.Name = "BuferTB";
      this.BuferTB.Size = new System.Drawing.Size(65, 22);
      this.BuferTB.TabIndex = 22;
      this.BuferTB.Text = "10";
      this.BuferTB.Visible = false;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(860, 416);
      this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(54, 16);
      this.label8.TabIndex = 23;
      this.label8.Text = "Буфер:";
      this.label8.Visible = false;
      // 
      // button1
      // 
      this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.button1.Location = new System.Drawing.Point(376, 64);
      this.button1.Margin = new System.Windows.Forms.Padding(4);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(173, 45);
      this.button1.TabIndex = 24;
      this.button1.Text = "Сгенерировать";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(815, 531);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.BuferTB);
      this.Controls.Add(this.SwitchLabel);
      this.Controls.Add(this.Switch);
      this.Controls.Add(this.SizeTB);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.Swapbutton);
      this.Controls.Add(this.Generate);
      this.Controls.Add(this.BTextBox);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.Decrypt);
      this.Controls.Add(this.Encrypt);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.QTextBox);
      this.Controls.Add(this.PTextBox);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.SaveFile);
      this.Controls.Add(this.OpenFile);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.OutputTB);
      this.Controls.Add(this.InputTB);
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "Form1";
      this.Text = "Рабин";
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputTB;
        private System.Windows.Forms.TextBox OutputTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.Button SaveFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PTextBox;
        private System.Windows.Forms.TextBox QTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Encrypt;
        private System.Windows.Forms.Button Decrypt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox BTextBox;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Swapbutton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SizeTB;
        private System.Windows.Forms.Button Switch;
        private System.Windows.Forms.Label SwitchLabel;
        private System.Windows.Forms.TextBox BuferTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}

