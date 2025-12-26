using Tyuiu.AroyanAV.Sprint5.Task4.V4.Lib;

namespace Tyuiu.AroyanAV.Sprint5.Task4.V4;

internal class Program
{
    static void Main(string[] args)
    {

        DataService ds = new DataService();

Console.Title = "Спринт #5 | Выполнилa: Ароян Армине Вачагановна | ИСТНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл      *");
Console.WriteLine("* Задание #4                                                              *");
Console.WriteLine("* Вариант #4                                                              *");
Console.WriteLine("* Выполнила: Ароян А. В. | ИИПб-25-1                                  *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

string path = @"C:\пользователи\armine06\документы\новая папка\Tyuiu.AroyanAV.Sprint5\OutPutFileTask4V4.bin";
        Console.WriteLine("Данные находятся в файле: " + path);
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine(ds.LoadFromDataFile(path));
Console.ReadKey();


Console.ReadKey();
    }
}
