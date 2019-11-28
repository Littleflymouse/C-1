using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Русин Евгений
            //а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). 
            //Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
            //б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.

            

            Console.WriteLine("Введите координаты первой точки");
            Console.Write("x1 ");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y1 ");
            y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координаты первой точки");
            Console.Write("x2 ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y2 ");
            y2 = Convert.ToDouble(Console.ReadLine());


            Distanse();


        }
        static void Distanse()
        {
            
            double resultDistance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"Расстояние между точками равно: {resultDistance:f}");

        }
        public static double x1, y1, x2, y2;
    }
}
