using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

// author: Денисова Екатерина

namespace async_await
{
    // класс для копирования файлов
    public class FileCopier
    {
        // метод, выполняющий длительную задачу (копирование данных из одного файла в другой)
        // progress - прогресс выполнения операции
        // sourceFilePath - файл, из которого копируются данные
        // destFilePath - файл, в который копируются данные
        // token - токен для отмены операции 
        public static async Task CopyFromFile(IProgress<int> progress, string sourceFilePath, string destFilePath, CancellationToken token)
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
        }



    }
}
