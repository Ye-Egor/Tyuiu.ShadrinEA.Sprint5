using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using Tyuiu.ShadrinEA.Sprint5.Task0.V30.Lib;

namespace Tyuiu.ShadrinEA.Sprint5.Task0.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Шадрин Е.А | ИСТНб-23-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #5                                                                    *");
            Console.WriteLine("* Задание #0                                                                   *");
            Console.WriteLine("* Вариант #30                                                                  *");
            Console.WriteLine("* Выполнил: Шадрин Егор Андреевич | ИСТНб-23-1                                 *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Дано выражение вычислить его значение при x = 3, результат сохранить в       *");
            Console.WriteLine("* текстовый файл OutPutFileTask0.txt и вывести на консоль.                     *");


            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("* y(x)=(x^2+1)/(3x+4)                                                          *");
            Console.WriteLine("********************************************************************************");

           

            int x = 3;
            Console.WriteLine("x = " + x);


            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");

            string res = ds.SaveToFileTextData(x);


            Console.WriteLine("Фаил: "+ res);
            Console.WriteLine("Создан!");

            Console.ReadKey();
        }
    }
}
