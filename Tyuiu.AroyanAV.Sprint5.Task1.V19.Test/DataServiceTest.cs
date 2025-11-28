using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AroyanAV.Sprint5.Task1.V19.Lib;
using System.IO;
namespace Tyuiu.AroyanAV.Sprint5.Task1.V19.Test
{
    [TestClass]
    public sealed class DataServiseTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\kmert\AppData\Local\Temp\OutPutFileTask1";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = false;
            Assert.AreEqual(wait, fileExists);
        }
    }
}