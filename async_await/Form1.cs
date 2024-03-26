using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace async_await
{
    public partial class Form1 : Form
    {
        // токен для отмены операции
        // отправляет токену CancellationToken сигнал отмены
        private CancellationTokenSource cts; 

        public Form1()
        {
            InitializeComponent();
        }

        // метод, выполняющий длительную задачу (копирование данных из одного файла в другой)
        // 
        private async Task DoSlowOperation(IProgress<int> progress, string sourceFilePath, string destFilePath, CancellationToken token)
        {

            string sourceFile = sourceFilePath;
            string destFile = destFilePath;

            if (!string.IsNullOrEmpty(sourceFile) && !string.IsNullOrEmpty(destFile))
            {
                //File.Copy(sourceFile, destFile, true);


                using (StreamReader reader = File.OpenText(sourceFilePath))
                using (StreamWriter writer = File.CreateText(destFilePath))
                {
                    char[] buffer = new char[1024];
                    int bytesRead;
                    long totalBytesRead = 0;
                    long fileSize = new FileInfo(sourceFilePath).Length;

                    while ((bytesRead = await reader.ReadAsync(buffer, 0, buffer.Length)) > 0)
                    {
                        if (token.IsCancellationRequested)
                        {
                            token.ThrowIfCancellationRequested();
                        }

                        await writer.WriteAsync(buffer, 0, bytesRead);
                        totalBytesRead += bytesRead;

                        // Отображение прогресса
                        int progressPercentage = (int)((totalBytesRead * 100) / fileSize);
                        progressBar.Value = progressPercentage;
                    }
                }



            }


        }

        private async void button_res_Click(object sender, EventArgs e)
        {

            // Деактивируем кнопку
            button_res.Enabled = false;

            string sourceFilePath = textBox_read.Text;
            string destFilePath = textBox_write.Text;

            cts = new CancellationTokenSource();
            var progress = new Progress<int>(value =>
            {
                progressBar.Value = value; // Обновление значения ProgressBar
            });

            try
            {
                await DoSlowOperation(progress, sourceFilePath, destFilePath, cts.Token); // Выполнение медленной операции с отслеживанием прогресса
                MessageBox.Show("Операция завершена!");
            }
            catch (OperationCanceledException)
            {
                MessageBox.Show("Операция прервана пользователем.");
            }
            finally
            {
                progressBar.Value = 0; // Сброс прогресса
            }

            // Активируем кнопку после завершения операции
            button_res.Enabled = true;

        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            cts.Cancel(); // Отмена операции по запросу пользователя
        
        }

        private void button_read_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog.FileName;
                textBox_read.Text = selectedFileName;
            }
        }

        private void button_write_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = saveFileDialog.FileName;
                textBox_write.Text = selectedFileName;
            }
        }
    }
}
