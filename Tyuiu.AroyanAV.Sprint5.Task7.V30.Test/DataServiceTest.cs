using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AroyanAV.Sprint5.Task7.V30.Lib;
using System.IO;

namespace Tyuiu.AroyanAV.Sprint5.Task7.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFileExists()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask7V30.txt";
            Assert.IsTrue(File.Exists(path), "Входной файл отсутствует.");
        }

        [TestMethod]
        public void ValidReplacementLogic()
        {
            string tempInput = Path.GetTempFileName() + ".txt";
            string original = "сегодня 12 завтра 4 послезавтра 34 и потом 4 5 6";
            File.WriteAllText(tempInput, original);

            try
            {
                DataService ds = new DataService();
                string result = ds.LoadDataAndSave(tempInput);

                string expected = "сегодня 12 завтра 9 послезавтра 34 и потом 9 9 9";
                Assert.AreEqual(expected, result, "Замена выполнена некорректно.");
            }
            finally
            {
                if (File.Exists(tempInput)) File.Delete(tempInput);
            }
        }
    }
}
