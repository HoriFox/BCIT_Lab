using System;

namespace ProjectLaba
{
    class ГеометрическаяФигура
    {
        public virtual void getS()
        {

        }
    }
    class Прямоугольник : ГеометрическаяФигура
    {
        private double ширина;
        private double высота;

        public Прямоугольник(double ширина, double высота) { }
    }
    class Квадрат : Прямоугольник
    {
        private double сторона;

        public Квадрат(double строна, double сторона) { }
    }
}
