using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taks4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Русин Евгений
            /*
            Написать программу обмена значениями двух переменных:
            а) с использованием третьей переменной;
            б) *без использования третьей переменной.
            */

            int num1, num2;

            num1 = 10;
            num2 = 30;

            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;
                              
            Console.WriteLine(num1);
            Console.WriteLine(num2);
                    
                             
        }
        
    }
}
