
using Tyuiu.AroyanAV.Sprint5.Task4.V4.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #5| Выполнил: Балин В.В. | СМАРТб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                        *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #4                                                             *");
        Console.WriteLine("* Выполнила: Балин В.В. | СМАРТб-25-1                                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дано выражение, вычислить его значение при x = 3, результат сохранить в *");
        Console.WriteLine("* текстовый файл OutPutFileTask0.txt и вывести на консоль.                *");
        Console.WriteLine("* Округлить до трёх знаков после запятой                                  *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        DataService ds = new DataService();
        string path = Path.Combine(Path.GetTempPath(), "DataSprint5", "InPutDataFileTask4V4.txt");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        double res = ds.LoadFromDataFile(path);
        Console.WriteLine(res);
        Console.ReadKey();
    }
}