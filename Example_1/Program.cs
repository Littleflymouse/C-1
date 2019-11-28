using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Русин Евгений
            /*Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес).В результате вся информация выводится в одну строчку:
            а) используя склеивание;
            б) используя форматированный вывод;
            в) используя вывод со знаком $.
            */

            string name, surname, age, height, weight;  
            
            Console.WriteLine("Введите ваше имя");
            name = Console.ReadLine();

            Console.WriteLine("Введите вашу фамилию");
            surname = Console.ReadLine();

            Console.WriteLine("Введите ваш возраст");
            age = Console.ReadLine();

            Console.WriteLine("Введите ваш рост");
            height = Console.ReadLine();
            
            Console.WriteLine("Введите ваш Вес");
            weight = Console.ReadLine();

            Console.WriteLine("имя: " + name + " фамилия: " + surname + " возраст: " + age + " рост: " + height + " вес: " + weight);
            Console.WriteLine("имя: {0} фамилия: {1} возраст: {2} рост: {3} вес: {4}", name, surname, age, height, weight);
            Console.WriteLine($"имя: {name} фамилия: {surname} возраст: {age} рост: {height} вес: {weight}");



        }
    }
}
