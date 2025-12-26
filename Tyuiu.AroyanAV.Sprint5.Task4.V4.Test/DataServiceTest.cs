using Tyuiu.AroyanAV.Sprint5.Task4.V4.Lib;

namespace Tyuiu.AroyanAV.Sprint5.Task4.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\пользователи\armine06\документы\новая папка\Tyuiu.AroyanAV.Sprint5\OutPutFileTask4V4.bin";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            Assert.AreEqual(false, fileExists);
        }
    }
}
