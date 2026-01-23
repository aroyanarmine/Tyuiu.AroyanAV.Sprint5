
using Tyuiu.AroyanAV.Sprint5.Task4.V4.Lib;
internal class Program
{
    static void Main(string[] args)
    {


        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнилa: Ароян А. В. | ИСТНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл      *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #4                                                              *");
        Console.WriteLine("* Выполнила: Ароян А. В. | ИСТНб-25-1                                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string path = Path.Combine(@"C:\DataSprint5", "InPutDataFileTask4V4.txt");
        Console.WriteLine("Данные находятся в файле: " + path);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(ds.LoadFromDataFile(path));
        Console.ReadKey();


        Console.ReadKey();
    }
}
