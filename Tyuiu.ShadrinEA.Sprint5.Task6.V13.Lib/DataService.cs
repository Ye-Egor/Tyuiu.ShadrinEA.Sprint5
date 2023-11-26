using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ShadrinEA.Sprint5.Task6.V13.Lib
{
    public class DataService : ISprint5Task6V13
    {
        public int LoadFromDataFile(string path)
        {
            using (StreamReader rd = new StreamReader(path))
            {
                string line;
                int k = 0;
                while ((line = rd.ReadLine()) != null)
                {
                    for (int i=0; i< line.Length;i++)
                    {
                        if( line[i]=='с' && line[i+1]=='с')
                        {
                            k++;
                        }
                    }
                }
                return k;
            }
        }
    }
}
