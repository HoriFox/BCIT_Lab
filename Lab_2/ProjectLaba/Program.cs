using System;

namespace ProjectLaba
{
    interface IPrint
    {
        void Print();
    }
    public abstract class GeometricFigure
    {
        public virtual double getS() // Получить площадь данной фигуры
        {
            return 0;
        }
    }
    public class Rectangle : GeometricFigure, IPrint // Прямоугольник
    {
        double width;
        double height;

        public Rectangle(double _width, double _height)
        {
            this.width = _width;
            this.height = _height;
        }
        public override double getS()
        {
            return width*height;
        }
        public virtual void Print()
        {
            Console.Write(ToString());
        }
        public override string ToString()
        {
            return "Rectangle: Area = " + getS();
        }
    }
    public class Square : Rectangle // Квадрат
    {
        private double side;

        public Square(double _side) : base(_side, _side)
        {
            this.side = _side; // Бесмыслица
        }
        public override void Print()
        {
            Console.Write(ToString());
        }
        public override string ToString()
        {
            return "Square: Area = " + getS();
        }
    }
    public class Circle : GeometricFigure // Круг
    {
        private double radius;

        public Circle(double _radius)
        {
            this.radius = _radius;
        }
        public override double getS()
        {
            return Math.PI*radius*radius; //Считать площадь
        }
        public virtual void Print()
        {
            Console.Write(ToString());
        }
        public override string ToString()
        {
            return "Circle: Area = " + getS();
        }
    }
    public class Program
    {
        static double inputVal(string prompt)
        {
            double a = 0;
            do
                Console.Write(prompt);
            while (!double.TryParse(Console.ReadLine(), out a));
            return a;
        }
        static int inputInt()
        {
            int a = 0;
            int.TryParse(Console.ReadLine(), out a);
            return a;
        }
        static void Main()
        {
            double param1, param2;
            int select;
            bool work;
            do
            {
                Console.Clear();
                Console.Write("Выберите фигуру:\n1 | Прямоугольник\n2 | Квадрат\n3 | Круг\n");
                select = inputInt();

                switch(select)
                {
                    case 1:
                        Console.Clear();
                        param1 = inputVal("Enter width: ");
                        param2 = inputVal("Enter height: ");
                        Rectangle rectangle = new Rectangle(param1, param2);
                        rectangle.Print();
                        break;
                    case 2:
                        Console.Clear();
                        param1 = inputVal("Enter side: ");
                        Square square = new Square(param1);
                        square.Print();
                        break;
                    case 3:
                        Console.Clear();
                        param1 = inputVal("Enter radius: ");
                        Circle circle = new Circle(param1);
                        circle.Print();
                        break;
                }

                Console.Write("\nExit? (1/0) \n"); // Можно заменить на человеческое [y/n]
                string s = Console.ReadLine();     // Просто потому что это же C#
                work = (s == "0" || s == "");      // Тогда: work = (s == "n" || s == "");
            } while (work);
        }
    }
}
