using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите точность для вычисления суммы ряда, заданного формулой (задание 4-г)...");

            double e = Convert.ToDouble(Console.ReadLine()), count=0 , temp= Math.Pow(-2, 1) / 1;
            int fkt = 1;
            int KolElem = 0;

            for (int i = 1; Math.Abs(temp) >= e; i++ )
            {
                fkt *= i;
                count += Math.Pow(-2, i)/fkt;
                temp = Math.Pow(-2, i) / fkt;
                Console.WriteLine(temp);
                KolElem++;
            }

            Console.WriteLine("Сумма "+ KolElem+" элементов равна " + count);
            Console.ReadLine();


        }
    }
}
