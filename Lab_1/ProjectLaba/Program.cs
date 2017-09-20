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
            double a, b, c;
            bool work = true;
            while (work)
            {
                Console.Clear();

                do
                    Console.Write("Enter A: ");
                while (!double.TryParse(Console.ReadLine(), out a));
                a = Convert.ToInt32(a);

                do
                    Console.Write("Enter B: ");
                while (!double.TryParse(Console.ReadLine(), out b));
                a = Convert.ToInt32(b);

                do
                Console.Write("Enter C: ");
                while (!double.TryParse(Console.ReadLine(), out c)) ;
                a = Convert.ToInt32(c);

                double discriminant = (b * b) - 4 * a * c;

                if (discriminant < 0)
                {
                    Console.Write("This equation has no solution");
                }
                else if (discriminant == 0)
                {
                    double x = (- b + Math.Round(Math.Sqrt(discriminant), 2)) / 2 * a;
                    Console.Write("X = " + x);
                }
                else if (discriminant > 0)
                {
                    double x1 = (-b + Math.Round(Math.Sqrt(discriminant), 2)) / 2 * a;
                    double x2 = (-b - Math.Round(Math.Sqrt(discriminant), 2)) / 2 * a;
                    Console.Write("X1 = " + x1 + " X2 = " + x2);
                }

                Console.Write("\nExit? (1/0) \n");
                a = Convert.ToInt32(Console.ReadLine());
                if (a == 1)
                {
                    work = false;
                }
            }
        }
    }
}
