using Tyuiu.AroyanAV.Sprint5.Task4.V4.Lib;
namespace Tyuiu.AroyanAV.Sprint5.Task4.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Пользователи\armine06\Изображения\Datasprint5\InPutDataFileTask4V4.txt";
            string tempPath = Path.GetTempPath();


            string fileName = "InPutDataFileTask4V4.txt";
            string p = Path.Combine(tempPath, fileName);

            FileInfo fileInfo = new FileInfo(path);


            bool fileExists = fileInfo.Exists;


            bool wait = false;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
