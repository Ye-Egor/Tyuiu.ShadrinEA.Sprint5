using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint5;

using System.IO;

namespace Tyuiu.ShadrinEA.Sprint5.Task0.V30.Lib
{
    public class DataService : ISprint5Task0V30
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";

            double z = ((double)x * (double)x + 1) / (3 * (double)x + 4);

            z = Math.Round(z, 3);

            File.WriteAllText(path, Convert.ToString(z));
            return path;
        }
    }
}
