using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLaba
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;
            bool work = true;
            while (work)
            {
                Console.Write("Enter A: ");                     //Вывод данных | std::cout << ... << std::endl;          
                a = Convert.ToInt32(Console.ReadLine());        //Ввод данных  | std::cin >> ...;

                Console.Write("Enter B: ");
                b = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter C: ");
                c = Convert.ToInt32(Console.ReadLine());


                double discriminant = (b * b) - 4 * a * c;

                if (discriminant < 0) // 0 корней
                {
                    Console.Write("This ");
                }
                else if (discriminant == 0) // 1 корень
                {
                    double x1 = (- b + Math.Round(Math.Sqrt(discriminant), 2)) / 2 * a;
                }
                else if (discriminant > 0) // 2 корня
                {
                    double x1 = (-b + Math.Round(Math.Sqrt(discriminant), 2)) / 2 * a;
                    double x2 = (-b - Math.Round(Math.Sqrt(discriminant), 2)) / 2 * a;

                    Console.Write("X1 = " + x1);
                }

                Console.Write("Exit? (1/0) \n");
                a = Convert.ToInt32(Console.ReadLine());
                if (a == 1)
                {
                    work = false;
                }
            }
            Console.ReadKey();
        }
    }
}
