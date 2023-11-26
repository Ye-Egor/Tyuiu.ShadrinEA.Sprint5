using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ShadrinEA.Sprint5.Task5.V7.Lib
{
    public class DataService : ISprint5Task5V7
    {
        public double LoadFromDataFile(string path)
        {
            double min = 1000000000;
            using (StreamReader rd = new StreamReader(path))

            {
                int n = 1;
                int k = 1;
                string line;
                while ((line = rd.ReadLine()) != null)
                {
                    if (Convert.ToInt32(line) == Convert.ToDouble(line))
                    { 
                        int t = Convert.ToInt32(line);
                       while (n <= t)
                        {  
                            k = k * n;
                            n++;
                        }
                        break;

                    }

                }
                return k ;
            }
        }
    }
}
