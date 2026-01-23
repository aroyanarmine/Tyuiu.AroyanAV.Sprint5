using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AroyanAV.Sprint5.Task5.V1.Lib
{
    public class DataService : ISprint5Task5V1
    {
        public double LoadFromDataFile(string path)
        {
            {
                string[] a = File.ReadAllText(path).Split(", ");
                double s, d = 0;

                for (int i = 0; i < a.Length; i++)
                {
                    s = Convert.ToDouble(a[i]);
                    if (s % 2 == 0) d += s;
                }

                return d;
            }
        }
    }
}

