using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projejct.v._2
{
    public class Triangle
    {
        public double a;// первая сторона
        public double b;// вторая сторона
        public double c;// третья сторона
        public double h;// Высота
        public Triangle(double A, double B, double C) //Конструктор
        {
            a = A; //Создаём с заданными длинами сторон согласнозаданию
            b = B;
            c = C;
        }
        public Triangle(double A, double B, double C, double H) //Конструктор с высотой
        {
            a = A;
            b = B;
            c = C;
            h = H;
        }
        /*public string TriangleType
        {
            get
            {
                if (a == b && a == c && b == c)
                    return "ранвобедренний";
                else if (a == b || a == c || b == c)
            }
        }*/
        public Triangle() // Конструктор, создаст треугольник без указания переметров треугольника
        {
        }

        public string outputA() // выводим сторону а, данный метод возвращает строковое значение (атрибут string)
        {
            return Convert.ToString(a); // a - ссылка на внутреннее поле объекта класса
        }
        public string outputB()
        {
            return Convert.ToString(b); // выводим сторону b
        }
        public string outputC() // выводим сторону с
        {
            return Convert.ToString(c); //возврощает строку с
        }
        public double Perimeter() // сумма всех сторон типа double
        {
            double p = a + b + c; // вычисление
            return p; // возврат
        }
        public double perimeterforh()
        {
            return Perimeter() * 0.5; // Формула для вычисления
        }
        public double Height() // Вычисление высоту треугольника
        {

            double p = perimeterforh();
            double h = 2 * Math.Sqrt(p * (p - a) * (p - b) * (p - c)) / a; // Формула для вычисления
            return h; // Выводим высоту

        }
        public double Surface() // аналогично периметру
        {
            double p = (a + b + c) / 2;
            double s = Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
            return s;//возврас s
        }
        public double Surfaces_v() // аналогично периметру
        {
            double SET = 0;
            double s = Math.Sqrt(SET * a * h);
            return s;//возврас s
        }
        public double GetSetA // свойство позволяющее установить либо изменить значение стороны а
        {
            get
            { return a; }
            set
            { a = value; }
        }
        public double GetSetB // свойство позволяющее установить либо изменить значение стороны b
        {
            get
            { return b; }
            set
            { b = value; }
        }
        public double GetSetC // свойство позволяющее установить либо изменить значение стороны c
        {
            get
            { return c; }
            set
            { c = value; }
        }
        public bool ExistTriangle // свойство позволяющее установить, существует ли треугольник с заданыыми сторонами
        {
            get
            {
                if ((a > b + c) && (b > a + c) && (c > a + b))//сумма 2 сторон должна быть больше третьей
                    return false; //возврощает неверно
                else return true; //вызврощает верно
            }
        }
    }
}