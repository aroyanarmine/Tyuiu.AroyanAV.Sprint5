using Tyuiu.AroyanAV.Sprint5.Task5.V1.Lib;
using System;
using System.IO;

namespace Tyuiu.AroyanAV.Sprint5.Task5.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт 5 | Task 5 | Вариант 1 | Ароян А.В.";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Ароян А.В. | ИСТНб-25-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл, содержащий числа. Найти сумму всех чисел, делящихся на 2.     *");
            Console.WriteLine("* Результат вывести на консоль, округлив до 3 знаков после запятой.       *");
            Console.WriteLine("***************************************************************************");

            string directory = @"C:\DataSprint5";
            string fileName = "InPutDataFileTask5V1.txt";
            string filePath = Path.Combine(directory, fileName);

            Console.WriteLine($"Путь к файлу: {filePath}");
            Console.WriteLine();

            if (!File.Exists(filePath))
            {
                Console.WriteLine("Ошибка: Файл не найден!");
                Console.WriteLine("Убедитесь, что папка C:\\DataSprint5 существует и содержит файл InPutDataFileTask5V1.txt");
            }
            else
            {
                DataService ds = new DataService();
                try
                {
                    double result = ds.LoadFromDataFile(filePath);
                    Console.WriteLine($"Сумма чётных чисел: {result:F3}");
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
