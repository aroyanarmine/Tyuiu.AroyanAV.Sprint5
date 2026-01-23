using Tyuiu.AroyanAV.Sprint5.Task5.V1.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #5 | Выполнила: Ароян А. В. | ИСТНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Чтение набора данных из текстового файла                                *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #1                                                              *");
        Console.WriteLine("* Выполнила: Ароян Армине Вачагановна | ИСТНб-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Найти сумму всех чисел с признаками деления на 2.                       *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
        Console.WriteLine("***************************************************************************");
        string path = @"C:\DataSprint5\InPutDataFileTask5V1.txt";
        Console.WriteLine("* Путь: " + path + " *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(ds.LoadFromDataFile(path));
    }
}
