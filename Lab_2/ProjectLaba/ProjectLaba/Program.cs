using System;

namespace ProjectLaba
{
    interface IPrint
    {
        void Print();
    }
    public abstract class GeometricFigure
    {
        public virtual void getS() // Получить площадь данной фигуры
        {
            Console.Write("This is area");
        }
    }
    public class Rectangle : GeometricFigure, IPrint // Прямоугольник
    {
        private double width;
        private double height;

        public Rectangle(double width, double height) { }
        public override void getS() { }
        public virtual void Print()
        {
            Console.Write("Something print Recrangle");
        }
    }
    public class Square : Rectangle // Квадрат
    {
        private double side;

        public Square(double side) : base(side, side) { }
        public override void getS() { }
        public override void Print()
        {
            Console.Write("Something print Squere");
        }
    }
    public class Circle : GeometricFigure // Круг
    {
        private double radius;

        public Circle(double radius) { }
        public override void getS() { }
        public virtual void Print()
        {
            Console.Write("Something print Circle");
        }
    }
    public class Program
    {
        static void Main()
        {

        }
    }
}
