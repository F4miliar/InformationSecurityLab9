namespace InformationSecurityLab9
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
            this.textBoxDecrypted = new System.Windows.Forms.TextBox();
            this.textBoxEncrypted = new System.Windows.Forms.TextBox();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxDecrypted
            // 
            this.textBoxDecrypted.Location = new System.Drawing.Point(12, 12);
            this.textBoxDecrypted.Multiline = true;
            this.textBoxDecrypted.Name = "textBoxDecrypted";
            this.textBoxDecrypted.Size = new System.Drawing.Size(291, 135);
            this.textBoxDecrypted.TabIndex = 0;
            // 
            // textBoxEncrypted
            // 
            this.textBoxEncrypted.Location = new System.Drawing.Point(309, 12);
            this.textBoxEncrypted.Multiline = true;
            this.textBoxEncrypted.Name = "textBoxEncrypted";
            this.textBoxEncrypted.Size = new System.Drawing.Size(291, 135);
            this.textBoxEncrypted.TabIndex = 1;
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(265, 153);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(82, 45);
            this.buttonEncrypt.TabIndex = 2;
            this.buttonEncrypt.Text = "Шифровать";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 210);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.textBoxEncrypted);
            this.Controls.Add(this.textBoxDecrypted);
            this.Name = "Form1";
            this.Text = "Одноразовая система подстановки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDecrypted;
        private System.Windows.Forms.TextBox textBoxEncrypted;
        private System.Windows.Forms.Button buttonEncrypt;
    }
}

