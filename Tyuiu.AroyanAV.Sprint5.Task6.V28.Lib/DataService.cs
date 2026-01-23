using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AroyanAV.Sprint5.Task6.V28.Lib
{
    public class DataService : ISprint5Task6V28
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            string content = File.ReadAllText(path);

            string[] tokens = content.Split(new char[] { ' ', '\t', '\n', '\r' },
                                          System.StringSplitOptions.RemoveEmptyEntries);

            foreach (string token in tokens)
            {
                if (token.Length == 4 && IsDigitsOnly(token))
                {
                    if (int.TryParse(token, out int number) && number >= 1000 && number <= 9999)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
        private bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }
    }
}
