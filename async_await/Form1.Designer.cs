namespace async_await
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
            this.button_res = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.button_read = new System.Windows.Forms.Button();
            this.button_write = new System.Windows.Forms.Button();
            this.textBox_read = new System.Windows.Forms.TextBox();
            this.textBox_write = new System.Windows.Forms.TextBox();
            this.label_read = new System.Windows.Forms.Label();
            this.label_write = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_res
            // 
            this.button_res.Location = new System.Drawing.Point(249, 274);
            this.button_res.Name = "button_res";
            this.button_res.Size = new System.Drawing.Size(75, 23);
            this.button_res.TabIndex = 0;
            this.button_res.Text = "Вычислить";
            this.button_res.UseVisualStyleBackColor = true;
            this.button_res.Click += new System.EventHandler(this.button_res_Click);
            // 
            // button_stop
            // 
            this.button_stop.Location = new System.Drawing.Point(462, 274);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(75, 23);
            this.button_stop.TabIndex = 1;
            this.button_stop.Text = "Остановить";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(127, 346);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(552, 23);
            this.progressBar.TabIndex = 2;
            // 
            // button_read
            // 
            this.button_read.Location = new System.Drawing.Point(530, 103);
            this.button_read.Name = "button_read";
            this.button_read.Size = new System.Drawing.Size(75, 23);
            this.button_read.TabIndex = 3;
            this.button_read.Text = "Файл";
            this.button_read.UseVisualStyleBackColor = true;
            this.button_read.Click += new System.EventHandler(this.button_read_Click);
            // 
            // button_write
            // 
            this.button_write.Location = new System.Drawing.Point(530, 150);
            this.button_write.Name = "button_write";
            this.button_write.Size = new System.Drawing.Size(75, 23);
            this.button_write.TabIndex = 4;
            this.button_write.Text = "Файл";
            this.button_write.UseVisualStyleBackColor = true;
            this.button_write.Click += new System.EventHandler(this.button_write_Click);
            // 
            // textBox_read
            // 
            this.textBox_read.Location = new System.Drawing.Point(374, 106);
            this.textBox_read.Name = "textBox_read";
            this.textBox_read.Size = new System.Drawing.Size(136, 20);
            this.textBox_read.TabIndex = 5;
            // 
            // textBox_write
            // 
            this.textBox_write.Location = new System.Drawing.Point(374, 152);
            this.textBox_write.Name = "textBox_write";
            this.textBox_write.Size = new System.Drawing.Size(136, 20);
            this.textBox_write.TabIndex = 6;
            // 
            // label_read
            // 
            this.label_read.AutoSize = true;
            this.label_read.Location = new System.Drawing.Point(246, 109);
            this.label_read.Name = "label_read";
            this.label_read.Size = new System.Drawing.Size(100, 13);
            this.label_read.TabIndex = 7;
            this.label_read.Text = "Файл для чтения: ";
            // 
            // label_write
            // 
            this.label_write.AutoSize = true;
            this.label_write.Location = new System.Drawing.Point(250, 155);
            this.label_write.Name = "label_write";
            this.label_write.Size = new System.Drawing.Size(99, 13);
            this.label_write.TabIndex = 8;
            this.label_write.Text = "Файл для записи:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_write);
            this.Controls.Add(this.label_read);
            this.Controls.Add(this.textBox_write);
            this.Controls.Add(this.textBox_read);
            this.Controls.Add(this.button_write);
            this.Controls.Add(this.button_read);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.button_res);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_res;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button button_read;
        private System.Windows.Forms.Button button_write;
        private System.Windows.Forms.TextBox textBox_read;
        private System.Windows.Forms.TextBox textBox_write;
        private System.Windows.Forms.Label label_read;
        private System.Windows.Forms.Label label_write;
    }
}

