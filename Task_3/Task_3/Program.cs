using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {

            // перевод массива строк с координатами в числовые значения
            static double[] ConvertToInt(string[] MasXY, double[] MasXYDouble)
            {
                MasXYDouble[0] = Convert.ToDouble(MasXY[0]);
                MasXYDouble[1] = Convert.ToDouble(MasXY[1]);

                return MasXYDouble;
            }

            // вычисление принадлежности 
            static void IfTrue(ref bool Ok, double[] MasXYDouble)
            {
                double X = MasXYDouble[0], Y = MasXYDouble[1];

                if (X >= 0)
                {
                    if (X * X + Y * Y <= 1) Ok = true;
                }
                else
                {
                    if ((Y <= X / 2 + 1) && (Y >= -X / 2 - 1)) Ok = true;
                }
            }

            static void Main(string[] args)
            {
                string[] MasXY = new string[2];
                double[] MasXYDouble = new double[2];
                bool Ok = false;
                
                
                Console.WriteLine("Введите координаты точки серез пробел");

                MasXY = Console.ReadLine().Split(' ');

                try
                {
                    ConvertToInt(MasXY, MasXYDouble);
                    IfTrue(ref
                    Ok, MasXYDouble);
                    Console.WriteLine(Ok);
                    Console.ReadLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("Неверный ввод координат");
                    Console.ReadLine();
                }
            }
        
    
    }
}
