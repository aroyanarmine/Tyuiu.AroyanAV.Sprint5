using Tyuiu.AroyanAV.Sprint5.Task7.V30.Lib;
using System;
using System.IO;

namespace Tyuiu.AroyanAV.Sprint5.Task7.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Ароян А.В. | ИСТНб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка текстовых файлов                                        *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнил: Ароян А.В. | ИСТНб-25-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Заменить все однозначные числа в файле на число \"9\".                  *");
            Console.WriteLine("* Результат сохранить в файл OutPutDataFileTask7V30.txt.                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string inputPath = Path.Combine(@"C:\DataSprint5", "InPutDataFileTask7V30.txt");
            Console.WriteLine($"Входной файл: {inputPath}");

            if (!File.Exists(inputPath))
            {
                Console.WriteLine("\n❌ Ошибка: Файл не найден!");
                Console.WriteLine("👉 Создайте папку C:\\DataSprint5 и поместите туда файл InPutDataFileTask7V30.txt");
            }
            else
            {
                try
                {
                    DataService ds = new DataService();
                    string result = ds.LoadDataAndSave(inputPath);

                    string outputPath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V30.txt");

                    Console.WriteLine("***************************************************************************");
                    Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
                    Console.WriteLine("***************************************************************************");
                    Console.WriteLine(result);
                    Console.WriteLine($"\n Результат сохранён в:\n{outputPath}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\n Ошибка: {ex.Message}");
                }
            }

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
