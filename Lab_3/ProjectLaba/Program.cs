using System;
using System.Collections;
using System.Collections.Generic;

namespace ProjectLaba
{
    public abstract class GeometricFigure : IComparable
    {
        public abstract double area();         // Площадь фигуры
        public int CompareTo(object figure)
        {
            GeometricFigure figure2 = (GeometricFigure)figure;
            if (this.area() < figure2.area())
                return -1;
            else if (this.area() > figure2.area())
                return 1;
            else return 0;
        }
    }
    public class Rectangle : GeometricFigure // Прямоугольник
    {
        double width;
        double height;
        public override double area() { return width * height; }
        public Rectangle (double _width, double _height)
        {
            width = _width;
            height = _height;
        }
    }
    public class Square : Rectangle         // Квадрат
    {
        public Square(double _side) : base(_side, _side) { }
    }
    public class Circle : GeometricFigure   // Круг
    {
        double radius;
        public override double area() { return Math.PI * radius * radius; }
        public Circle(double _radius)
        {
            radius = _radius;
        }
    }
    //public class SimpleStack : SimpleList
    //{

    //}

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
            int select;
            bool work;
            do
            {
                Console.Clear();
                Console.Write("Виберите нужную функцию:\n1 | Добавить и отсортировать фигуры\n2 | Работа с матрицей\n3 | Работа с SimpleStack\nВаш выбор: ");
                select = inputInt();

                switch(select)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("ArrayList: \n");
                        ArrayList collection = new ArrayList();
                        collection.Add(new Rectangle(20, 40));
                        collection.Add(new Rectangle(30, 40));
                        collection.Add(new Rectangle(80, 40));
                        collection.Sort();
                        foreach (GeometricFigure p in collection)
                        {
                            Console.Write(p.area() + "\n");
                        }

                        Console.Write("\nList<GeometricFigure>: \n");
                        List<GeometricFigure> collection2 = new List<GeometricFigure>();
                        collection2.Add(new Rectangle(40, 40));
                        collection2.Add(new Rectangle(80, 40));
                        collection2.Add(new Rectangle(40, 45));
                        collection2.Sort();
                        foreach (GeometricFigure p in collection2)
                        {
                            Console.Write(p.area() + "\n");
                        }
                    break;
                    case 2:

                    break;
                    case 3:

                    break;
                }


                Console.Write("\nContinue? (y/n) \n");
                string s = Console.ReadLine();     
                work = (s == "y" || s == "");
            } while (work);
        }
    }
}
