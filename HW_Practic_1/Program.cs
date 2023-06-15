using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace HW_Practic_1
{
    internal class Program
    {
        static void Task2()
        {
            Console.WriteLine("Enter Number: ");
            int Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Percent: ");
            int Percent = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Result: " + ((Number * Percent) / 100));
        }
        static void Task3()
        {
            Console.WriteLine("Enter four digits: ");
            int[] ints = new int[4];
            ints[0] = Convert.ToInt32(Console.ReadLine());
            ints[1] = Convert.ToInt32(Console.ReadLine());
            ints[2] = Convert.ToInt32(Console.ReadLine());
            ints[3] = Convert.ToInt32(Console.ReadLine());
            int total = ints[0] * 1000 + ints[1] * 100 + ints[2] * 10 + ints[3];
            Console.WriteLine("Total: " + total);
        }
        static void Task4()
        {
            Console.WriteLine("Enter 6-digits number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number >= 100000 && number <= 999999)
            {
                int temp = number / 100000 + number % 10 * 100000 + number % 100 / 10 * 10 + number % 1000 / 100 * 100
                    + number % 10000 / 1000 * 1000 + number % 100000 / 10000 * 10000;
                Console.WriteLine("Result: " + temp);
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
        static void Task5()
        {
            Console.WriteLine("Enter year, month, day: ");
            int[] Date = new int[3];
            Date[0] = Convert.ToInt32(Console.ReadLine());
            Date[1] = Convert.ToInt32(Console.ReadLine());
            Date[2] = Convert.ToInt32(Console.ReadLine());
            DateTime dateTime = new DateTime(Date[0], Date[1], Date[2]);
            Console.WriteLine((Date[1] == 0 || Date[1] == 2 || Date[1] == 12 ? "Winter " : (Date[1] >= 3 && Date[1] <= 5 ? "Spring " :
                (Date[1] >= 6 && Date[1] <= 8 ? "Summer " : "Autumn "))) + dateTime.DayOfWeek);
        }
        static void Task6()
        {
            Console.WriteLine("Enter temperatue: ");
            double temperatur = Convert.ToInt32(Console.ReadLine());
            int choise = 1;
            Console.WriteLine("Choose convert:\n1 - to C^\n2 - to F^\n0 - exit");
            while(choise != 0)
            {
                choise = Convert.ToInt32(Console.ReadLine());
                if (choise == 1)
                {
                    temperatur = (temperatur - 32) / 1.8;
                }
                else if (choise == 2)
                {
                    temperatur = temperatur * 1.8 + 32;
                }
                else if (choise == 0)
                {
                    break;
                }
                Console.WriteLine(temperatur);
            }
        }
        static void Task7()
        {
            Console.WriteLine("Enter two numbers: ");
            int num0 = Convert.ToInt32(Console.ReadLine());
            int num1 = Convert.ToInt32(Console.ReadLine());
            if (num0 > num1)
            {
                int temp = num0;
                num0 = num1;
                num1 = temp;
            }
            for (int i = num0; i < num1; i++)
            {
                if ((i % 2) == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void Main(string[] args)
        {
            Task2();
            Task3();
            Task4();
            Task5();
            Task6();
            Task7();
        }
    }
}
