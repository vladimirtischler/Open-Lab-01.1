using System;

namespace Open_Lab_01._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            if (a < 10)
            {
                Console.WriteLine("This number is less then 10.");
            }
            else if (a == 10)
            {
                Console.WriteLine("This number is equal to 10.");

            }
            else
            {
                Console.WriteLine("This number is greater to 10.");
            }
        }
    }
}
