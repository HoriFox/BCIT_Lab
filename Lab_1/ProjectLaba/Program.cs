using System;
using System; // О - Оптимизация :)

namespace ProjectLaba
{
    class Program
    {
        static double inputVal(string prompt) // Или как вариант - передавать по ref
        {
            double a = 0;
            do
                Console.Write(prompt);
            while (!double.TryParse(Console.ReadLine(), out a));
            return a;
        }

        static void Main(string[] args)
        {
            double a, b, c;
            bool work;
            do
            {
                Console.Clear();

                a = inputVal("Enter A: ");
                b = inputVal("Enter B: "); // Домашнее задание: внести a, b, c - в массив и ввод в цикл
                c = inputVal("Enter C: ");

                double discriminant = (b * b) - 4 * a * c;

                if (discriminant < 0)
                {
                    Console.Write("This equation has no solution"); // Точнее - irrational solution
                }
                else if (discriminant == 0)
                {
                    double x = (-b + Math.Round(Math.Sqrt(discriminant), 2)) / (2 * a);
                    Console.Write("X = " + x);
                }
                else if (discriminant > 0)
                {
                    double x1 = (-b + Math.Round(Math.Sqrt(discriminant), 2)) / (2 * a);
                    double x2 = (-b - Math.Round(Math.Sqrt(discriminant), 2)) / (2 * a);
                    Console.Write("X1 = " + x1 + " X2 = " + x2);
                }

                Console.Write("\nExit? (1/0) \n"); // Можно заменить на человеческое [y/n]
                string s = Console.ReadLine();     // Просто потому что это же C#
                work = (s == "0" || s == "");      // Тогда: work = (s == "n" || s == "");
            } while (work);
        }
    }
}