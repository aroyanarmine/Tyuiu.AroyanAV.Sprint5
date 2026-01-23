using Tyuiu.AroyanAV.Sprint5.Task5.V1.Lib;

namespace Tyuiu.AroyanAV.Sprint5.Task5.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask5V1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool expected = true;
            Assert.AreEqual(expected, fileExists);
        }
    }
}
