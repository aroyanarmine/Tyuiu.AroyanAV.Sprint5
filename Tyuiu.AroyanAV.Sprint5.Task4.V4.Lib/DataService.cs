using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AroyanAV.Sprint5.Task4.V4.Lib
{
    public class DataService : ISprint5Task4V4
    {
        public double LoadFromDataFile(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException($"Файл не найден: {path}");

            string text = File.ReadAllText(path).Trim();

            if (!double.TryParse(text, NumberStyles.Float, CultureInfo.InvariantCulture, out double x))
                throw new FormatException("Невозможно преобразовать содержимое файла в вещественное число.");

            double result = (0.25 * x) / Math.Cos(x);

            return Math.Round(result, 3);
        }
    }
}
