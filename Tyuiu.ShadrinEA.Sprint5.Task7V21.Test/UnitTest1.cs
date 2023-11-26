using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.ShadrinEA.Sprint5.Task7V21.Lib;

namespace Tyuiu.ShadrinEA.Sprint5.Task7V21.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\meteo\source\repos\Tyuiu.ShadrinEA.Sprint5\DataSprint5\InPutDataFileTask7V21.txt";
            FileInfo fi = new FileInfo(path);
            bool fileExists = fi.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

        }
    }
}
