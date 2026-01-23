using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AroyanAV.Sprint5.Task6.V28.Lib;
using System.IO;

namespace Tyuiu.AroyanAV.Sprint5.Task6.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFileExists()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V28.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.IsTrue(fileExists, "Файл не найден по указанному пути.");
        }

        [TestMethod]
        public void ValidCountOfFourDigitNumbers()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask6V28.txt";

            // Убедимся, что файл существует
            Assert.IsTrue(File.Exists(path), "Тестовый файл отсутствует.");

            int result = ds.LoadFromDataFile(path);
            int expected = 3; // ← замени на реальное ожидаемое значение из твоего файла

            Assert.AreEqual(expected, result, $"Ожидалось {expected}, получено {result}");
        }
    }
}
