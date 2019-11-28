using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Русин Евгений
            //Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.

            Console.WriteLine("Введите ваш вес в килограммах ");
            float weight = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Введите ваш рост в метрах ");
            float heigth = Convert.ToSingle(Console.ReadLine());

            float result = weight / (heigth * heigth);
            Console.WriteLine("ИМП равен: " + result);


            

        }
    }
}
