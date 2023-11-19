using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.ShadrinEA.Sprint5.Task1.V6.Lib;

namespace Tyuiu.ShadrinEA.Sprint5.Task1.V6.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\meteo\source\repos\Tyuiu.ShadrinEA.Sprint5\Tyuiu.ShadrinEA.Sprint5.Task1.V6\bin\Debug\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);

            bool fileExists = fileInfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
