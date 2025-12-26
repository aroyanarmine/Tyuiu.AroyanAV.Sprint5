using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AroyanAV.Sprint5.Task4.V4.Lib
{
    public class DataService : ISprint5Task4V4
    {
        public double LoadFromDataFile(string path)
        {
            string n = File.ReadAllText(path);
            double v = double.Parse(n.Replace('.', ','));
            double x = v;
            double res = Math.Round(((0.25 * x) / (Math.Cos(x))), 3);
            return res;
            
        }
    }
}
