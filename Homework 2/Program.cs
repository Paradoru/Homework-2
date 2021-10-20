using System;

namespace Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите x:");
                double x = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите y:");
                double y = double.Parse(Console.ReadLine());
                if (x>=-1 && x<=1 && y>=0.5 & y<=1)
                    Console.WriteLine("Да");
                else
                    Console.WriteLine("Нет");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
