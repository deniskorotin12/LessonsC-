using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Program
    {

        static void Main(string[] args)
        {
            int myCount;
            Label:
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Введите пятизначное число: ");
            myCount = Convert.ToInt32(Console.ReadLine());
            if (myCount > 10000 && myCount < 99999)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Первое число = " + (myCount / 10000) % 10);
                Console.WriteLine("Второе число = " + (myCount / 1000) % 10);
                Console.WriteLine("Третье число = " + (myCount / 100) % 10);
                Console.WriteLine("Четвертое число = " + (myCount/10) % 10);
                Console.WriteLine("Пятое число = " + myCount % 10);
                Console.ReadKey();

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Вы ввели не пятизначеное число!");           
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                goto Label;
            }



        }

    }
}