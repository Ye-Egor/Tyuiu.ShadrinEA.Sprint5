using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.ShadrinEA.Sprint5.Task6.V13.Lib;

namespace Tyuiu.ShadrinEA.Sprint5.Task6.V13.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\meteo\source\repos\Tyuiu.ShadrinEA.Sprint5\DataSprint5\InPutDataFileTask6V13.txt";

            var res = ds.LoadFromDataFile(path);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\meteo\source\repos\Tyuiu.ShadrinEA.Sprint5\DataSprint5\InPutDataFileTask6V13.txt";

            FileInfo fi = new FileInfo(path);
            bool fileExists = fi.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

        }
    }
}
