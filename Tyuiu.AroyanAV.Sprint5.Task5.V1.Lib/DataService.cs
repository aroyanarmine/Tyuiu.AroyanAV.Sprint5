using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AroyanAV.Sprint5.Task5.V1.Lib
{
    public class DataService : ISprint5Task5V1
    {
        public double LoadFromDataFile(string path)
        {
            string content = File.ReadAllText(path);

            string[] parts = content.Split(new string[] { ", " }, StringSplitOptions.None);

            double sum = 0.0;

            foreach (string part in parts)
            {
                if (double.TryParse(part.Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out double number))
                {
                    if (Math.Abs(number % 2) < 1e-9) 
                    {
                        sum += number;
                    }
                }
            }

            return Math.Round(sum, 3);
        }
    }
}

