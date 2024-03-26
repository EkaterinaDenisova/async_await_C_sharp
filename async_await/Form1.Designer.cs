namespace async_await
{
    partial class Form_copy
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
            this.label_progress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_res
            // 
            this.button_res.Location = new System.Drawing.Point(332, 337);
            this.button_res.Margin = new System.Windows.Forms.Padding(4);
            this.button_res.Name = "button_res";
            this.button_res.Size = new System.Drawing.Size(100, 28);
            this.button_res.TabIndex = 0;
            this.button_res.Text = "Копировать";
            this.button_res.UseVisualStyleBackColor = true;
            this.button_res.Click += new System.EventHandler(this.button_res_Click);
            // 
            // button_stop
            // 
            this.button_stop.Location = new System.Drawing.Point(616, 337);
            this.button_stop.Margin = new System.Windows.Forms.Padding(4);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(100, 28);
            this.button_stop.TabIndex = 1;
            this.button_stop.Text = "Остановить";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(169, 426);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(736, 28);
            this.progressBar.TabIndex = 2;
            // 
            // button_read
            // 
            this.button_read.Location = new System.Drawing.Point(707, 127);
            this.button_read.Margin = new System.Windows.Forms.Padding(4);
            this.button_read.Name = "button_read";
            this.button_read.Size = new System.Drawing.Size(100, 28);
            this.button_read.TabIndex = 3;
            this.button_read.Text = "Файл";
            this.button_read.UseVisualStyleBackColor = true;
            this.button_read.Click += new System.EventHandler(this.button_read_Click);
            // 
            // button_write
            // 
            this.button_write.Location = new System.Drawing.Point(707, 185);
            this.button_write.Margin = new System.Windows.Forms.Padding(4);
            this.button_write.Name = "button_write";
            this.button_write.Size = new System.Drawing.Size(100, 28);
            this.button_write.TabIndex = 4;
            this.button_write.Text = "Файл";
            this.button_write.UseVisualStyleBackColor = true;
            this.button_write.Click += new System.EventHandler(this.button_write_Click);
            // 
            // textBox_read
            // 
            this.textBox_read.Location = new System.Drawing.Point(499, 130);
            this.textBox_read.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_read.Name = "textBox_read";
            this.textBox_read.Size = new System.Drawing.Size(180, 22);
            this.textBox_read.TabIndex = 5;
            // 
            // textBox_write
            // 
            this.textBox_write.Location = new System.Drawing.Point(499, 187);
            this.textBox_write.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_write.Name = "textBox_write";
            this.textBox_write.Size = new System.Drawing.Size(180, 22);
            this.textBox_write.TabIndex = 6;
            // 
            // label_read
            // 
            this.label_read.AutoSize = true;
            this.label_read.Location = new System.Drawing.Point(333, 133);
            this.label_read.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_read.Name = "label_read";
            this.label_read.Size = new System.Drawing.Size(123, 16);
            this.label_read.TabIndex = 7;
            this.label_read.Text = "Файл для чтения: ";
            // 
            // label_write
            // 
            this.label_write.AutoSize = true;
            this.label_write.Location = new System.Drawing.Point(333, 191);
            this.label_write.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_write.Name = "label_write";
            this.label_write.Size = new System.Drawing.Size(121, 16);
            this.label_write.TabIndex = 8;
            this.label_write.Text = "Файл для записи:";
            // 
            // label_progress
            // 
            this.label_progress.AutoSize = true;
            this.label_progress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_progress.Location = new System.Drawing.Point(166, 467);
            this.label_progress.Name = "label_progress";
            this.label_progress.Size = new System.Drawing.Size(44, 20);
            this.label_progress.TabIndex = 9;
            this.label_progress.Text = "label";
            // 
            // Form_copy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label_progress);
            this.Controls.Add(this.label_write);
            this.Controls.Add(this.label_read);
            this.Controls.Add(this.textBox_write);
            this.Controls.Add(this.textBox_read);
            this.Controls.Add(this.button_write);
            this.Controls.Add(this.button_read);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.button_res);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_copy";
            this.Text = "Копирование файлов";
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
        private System.Windows.Forms.Label label_progress;
    }
}

