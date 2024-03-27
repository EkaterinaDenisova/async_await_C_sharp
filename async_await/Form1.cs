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

// author: Денисова Екатерина

namespace async_await
{
    public partial class Form_copy : Form
    {
        // источник токена для отмены операции
        // отправляет токену CancellationToken сигнал отмены
        private CancellationTokenSource cts; 

        public Form_copy()
        {
            InitializeComponent();
            button_stop.Enabled = false;
            label_progress.Text = "";
        }

        // метод, выполняющий длительную задачу (копирование данных из одного файла в другой)
        // progress - прогресс выполнения операции
        // sourceFilePath - файл, из которого копируются данные
        // destFilePath - файл, в который копируются данные
        // token - токен для отмены операции 
        /*private async Task CopyFromFile(IProgress<int> progress, string sourceFilePath, string destFilePath, CancellationToken token)
        {

            string sourceFile = sourceFilePath;
            string destFile = destFilePath;

            if (!string.IsNullOrEmpty(sourceFile) && !string.IsNullOrEmpty(destFile))
            {
                //File.Copy(sourceFile, destFile, true);

                // открытие файлов для чтения и записи
                using (StreamReader reader = File.OpenText(sourceFilePath))
                using (StreamWriter writer = File.CreateText(destFilePath))
                {
                    char[] buffer = new char[1024];
                    int bytesRead;
                    long totalBytesRead = 0;
                    long fileSize = new FileInfo(sourceFilePath).Length;
                    
                    // ReadAsync асинхронно считывает последовательность байтов из текущего потока
                    // и перемещает позицию внутри потока на число считанных байтов. Возвращает Task
                    while ((bytesRead = await reader.ReadAsync(buffer, 0, buffer.Length)) > 0)
                    {
                        if (token.IsCancellationRequested)
                        {
                            // если был запрос на отмену операции, то выбрасываем исключение OperationCanceledException
                            token.ThrowIfCancellationRequested();
                        }

                        //WriteAsync асинхронно записывает последовательность байтов в текущий поток (stream) и
                        //перемещает текущую позицию внутри потока на число записанных байтов.
                        await writer.WriteAsync(buffer, 0, bytesRead);
                        totalBytesRead += bytesRead;

                        // отображение прогресса, вычисляется как процент от общего объёма файла
                        int progressPercentage = (int)((totalBytesRead * 100) / fileSize);

                        // Report - сообщение об изменении прогресса
                        // параметр - обновлённое значение прогресса
                        progress.Report(progressPercentage);
                        
                    }
                }



            }


        }*/

        // метод, вызываемый при нажатии кнопки "Копировать"
        private async void button_res_Click(object sender, EventArgs e)
        {
            // метод объявлен с ключевым словом async, значит он может быть приостановлен на время,
            // для выполнения основным потоком другой работы
            // Приостановка может быть только в месте выполения операций запущенных с ключевым словом await 

            button_stop.Enabled = true;

            // деактивируем кнопку
            button_res.Enabled = false;

            string sourceFilePath = textBox_read.Text;
            string destFilePath = textBox_write.Text;

            label_progress.Text = "Копирование файла...";

            // источник токена для отправки сигнала об отмене операции
            cts = new CancellationTokenSource();

            // предоставляет IProgress<T> , который вызывает обратные вызовы для каждого сообщаемого значения хода выполнения
            var progress = new Progress<int>(value =>
            {
                progressBar.Value = value; // Обновление значения ProgressBar
            });

            try
            {
                // выполнение медленной операции с отслеживанием прогресса
                await FileCopier.CopyFromFile(progress, sourceFilePath, destFilePath, cts.Token); // выполнение медленной операции с отслеживанием прогресса
                // async позволяет приостановить выполнение метода, сохранить его состояние,
                // до тех пор пока операция await запущенная в параллельном потоке, не завершится
                // await неблокирующее ожидание завершения операции

                label_progress.Text = "Копирование завершено!";
                //MessageBox.Show("Операция завершена!");
            }
            // обработка исключения, выбрасываемого, когда пользователь нажимает кнопку "Отмена"
            catch (OperationCanceledException)
            {
                label_progress.Text = "Операция прервана пользователем";
                //MessageBox.Show("Операция прервана пользователем.");
            }
            // блок выполняется в самом конце вне зависимости от того, были ли выброшены и обработаны исключения в блоке catch
            finally
            {
                progressBar.Value = 0; // Сброс прогресса
            }

            // активируем кнопку после завершения операции
            button_res.Enabled = true;

            button_stop.Enabled = false;
        }

        // метод при нажатии кнопки "Отмена"
        private void button_stop_Click(object sender, EventArgs e)
        {
            cts.Cancel(); // отмена операции по запросу пользователя
                          // устанавливает флаг cts.Token.IsCancellationRequested

        }

        // выбор файла для чтения
        private void button_read_Click(object sender, EventArgs e)
        {
            label_progress.Text = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog.FileName;
                textBox_read.Text = selectedFileName; // запись пути к файлу в поле textbox
            }

        }

        // выбор файла для записи
        private void button_write_Click(object sender, EventArgs e)
        {
            label_progress.Text = "";
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = saveFileDialog.FileName; 
                textBox_write.Text = selectedFileName; // запись пути к файлу в поле textbox
            }
        }
    }
}
