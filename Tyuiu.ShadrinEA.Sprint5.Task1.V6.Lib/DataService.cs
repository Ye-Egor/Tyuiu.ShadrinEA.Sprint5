using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ShadrinEA.Sprint5.Task1.V6.Lib
{
    public class DataService : ISprint5Task1V6
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask1.txt";
            FileInfo fi = new FileInfo(path);
            bool fileExists = fi.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }
            double y;
            string stry;
            for (int x = startValue; x <= stopValue; x++)
            {

                y = Math.Cos(x) + (4 * x) / 2 - Math.Sin(x) * 3 * x;
                if (double.IsInfinity(y) || double.IsNaN(y))
                {
                    y = 0;
                }
                y = Math.Round(y, 2);
                stry = Convert.ToString(y);
                if (x != stopValue)
                {
                    File.AppendAllText(path, stry + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, stry);
                }

            }
            return path;
        }
    }
}
