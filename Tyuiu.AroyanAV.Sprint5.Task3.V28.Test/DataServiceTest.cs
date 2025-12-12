using System.IO;
using Tyuiu.AroyanAV.Sprint5.Task3.V28.Lib;

namespace Tyuiu.AroyanAV.Sprint5.Task3.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\armine06\документы\новая папка\Tyuiu.AroyanAV.Sprint5\OutPutFileTask3.bin";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = false;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
