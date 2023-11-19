using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.ShadrinEA.Sprint5.Task2.V20.Lib;

namespace Tyuiu.ShadrinEA.Sprint5.Task1.V6.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\meteo\source\repos\Tyuiu.ShadrinEA.Sprint5\Tyuiu.ShadrinEA.Sprint5.Task2.V20\bin\Debug\OutPutFileTask2.csv";

            FileInfo fileInfo = new FileInfo(path);

            bool fileExists = fileInfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
