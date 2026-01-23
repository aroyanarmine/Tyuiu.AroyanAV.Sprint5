using Tyuiu.AroyanAV.Sprint5.Task6.V28.Lib;
using System;
using System.IO;

namespace Tyuiu.AroyanAV.Sprint5.Task6.V28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Ароян А.В. | ИСТНб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка текстовых файлов                                        *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("* Выполнил: Ароян А.В. | ИСТНб-25-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая находит количество четырёхзначных чисел     *");
            Console.WriteLine("* в заданной строке из текстового файла.                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string directory = @"C:\DataSprint5";
            string fileName = "InPutDataFileTask6V28.txt";
            string filePath = Path.Combine(directory, fileName);

            Console.WriteLine($"Путь к файлу: {filePath}");
            Console.WriteLine();

            if (!File.Exists(filePath))
            {
                Console.WriteLine("Ошибка: Файл не найден!");
                Console.WriteLine("Убедитесь, что папка C:\\DataSprint5 существует и содержит файл InPutDataFileTask6V28.txt");
            }
            else
            {
                DataService ds = new DataService();
                try
                {
                    int result = ds.LoadFromDataFile(filePath);
                    Console.WriteLine("***************************************************************************");
                    Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
                    Console.WriteLine("***************************************************************************");
                    Console.WriteLine(result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при обработке файла: {ex.Message}");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для завершения...");
            Console.ReadKey();
        }
    }
}
