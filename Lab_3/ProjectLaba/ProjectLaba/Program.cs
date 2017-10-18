using System;
using System.Collections;
using System.Collections.Generic;

namespace ProjectLaba
{
    public interface IComparable
    {
        int CompareTo(object figure);
    }
    public class GeometricFigure : IComparable<GeometricFigure>
    {
        public double area;         // Площадь фигуры
        public ArrayList collection;
        public GeometricFigure()
        {
            collection = new ArrayList();
        }
        public void AddInCollection(GeometricFigure figure)
        {
            collection.Add(figure);
        }
        public int CompareTo(GeometricFigure figure)
        {
            GeometricFigure figure2 = figure;
            if (this.area < figure2.area)
                return 1;
            else if (this.area > figure2.area)
                return -1;
            else return 0;
        }
    }

    public class Rectangle : GeometricFigure // Прямоугольник
    {
        public Rectangle (double width, double height)
        {
            area = width * height;
        }
    }
    public class Square : Rectangle         // Квадрат
    {
        public Square(double _side) : base(_side, _side) { }
    }
    public class Circle : GeometricFigure   // Круг
    {
        public Circle(double radius)
        {
            area = Math.PI * radius * radius;
        }
    }

    public class Program
    {
        static double inputDouble() // Проверка на введённый Double
        {
            double a = 0;
            double.TryParse(Console.ReadLine(), out a);
            return a;
        }
        static int inputInt()       // Проверка на введённый Int
        {
            int a = 0;
            int.TryParse(Console.ReadLine(), out a);
            return a;
        }
        static void Main()
        {
            bool work;
            do
            {
            // Меню
                GeometricFigure figure = new GeometricFigure();

                //figure.AddInCollection(new Rectangle(20, 40));
                //figure.AddInCollection(new Rectangle(20, 20));
                //figure.AddInCollection(new Rectangle(70, 70));
                //figure.AddInCollection(new Rectangle(10, 10));

                Rectangle rt1 = new Rectangle(20, 40);
                Rectangle rt2 = new Rectangle(40, 90);
                Rectangle rt3 = new Rectangle(10, 10);
                figure.AddInCollection(rt1);
                figure.AddInCollection(rt2);
                figure.AddInCollection(rt3);

                //int state = rt1.CompareTo(rt2);

                figure.collection.Sort();

                foreach (GeometricFigure p in figure.collection)
                {
                    Console.WriteLine("{0} - {1}", p.area);
                }

                //Console.WriteLine(state);

                //List<GeometricFigure> collection2 = new List<GeometricFigure>();
                //collection2.Add(new Rectangle(20, 40));


                Console.Write("\nContinue? (y/n) \n");
                string s = Console.ReadLine();     
                work = (s == "y" || s == "");
            } while (work);
        }
    }
}
