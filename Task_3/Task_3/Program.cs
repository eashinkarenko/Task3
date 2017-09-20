using System;

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
                // правее оси ординат
                if (X >= 0)
                {
                    if (X * X + Y * Y <= 1) Ok = true;
                }
                // левее оси ординат
                else
                {
                    if ((Y <= X / 2 + 1) && (Y >= -X / 2 - 1)) Ok = true;
                }
            }

            static void Main(string[] args)
            {
                string[] MasXY = new string[2];//входные данные
                double[] MasXYDouble = new double[2];//хранение координат точки
                bool Ok = false, Flag = false;

            // пока ввод не станет корректным
            while (Flag == false)
            {
                Console.WriteLine("Введите координаты точки через пробел");

                MasXY = Console.ReadLine().Split(' ');

                // на случай, если конвертирование строки в действительное число приведёт к ошибке
                try
                {
                    ConvertToInt(MasXY, MasXYDouble);
                    IfTrue(ref Ok, MasXYDouble);
                    Console.WriteLine(Ok);
                    Console.ReadLine();
                    Flag = true;
                }

                catch (Exception)
                {
                    Console.WriteLine("Неверный ввод координат");
                    Console.ReadLine();
                }
            }
            }   
    }
}
