using Tyuiu.AroyanAV.Sprint5.Task4.V4.Lib;
namespace Tyuiu.AroyanAV.Sprint5.Task4.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Пользователь\source\repos\Tyuiu.BalinVV.Sprint5\Tyuiu.BalinVV.Sprint5.Task4.V4\bin\Debug\InPutDataFileTask4V4.txt";
            string tempPath = Path.GetTempPath();


            string fileName = "InPutDataFileTask4V4.txt";
            string p = Path.Combine(tempPath, fileName);

            FileInfo fileInfo = new FileInfo(path);


            bool fileExists = fileInfo.Exists;


            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
