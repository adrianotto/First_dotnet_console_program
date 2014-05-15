using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string happydata = Console.ReadLine();
            Console.WriteLine("Enter your age");
            int Age = 0;
            try
            {
                Age = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Hello there " + happydata + " your age is " + Age);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Age should be numeric");
            }
            
        }
    }
}
