using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projejct.v._2
{
    public class Triangle
    {
        public double a; // первая сторона
        public double b; // вторая сторона
        public double c; // третья сторона
        public double ha; 
        public Triangle(double A, double B, double C) 
        {
            a = A; 
            b = B;
            c = C;
        }
        public Triangle() 
        {
        }
        public Triangle(double A, double HA) 
        {
            a = A; 
            ha = HA;
        }
        public double SurfaceAHA()
        {
            double s = (1 / 2) * a * ha;
            return s;
        }
        public double GetSetA 
        {
            get 
            { return a; }
            set 
            { a = value; }
        }
        public double GetSetB
        {
            get
            { return b; }
            set
            { b = value; }
        }
        public double GetSetC 
        {
            get
            { return c; }
            set
            { c = value; }
        }
        public bool ExistTriangle 
        {
            get
            {
                if ((a < b + c) && (b < a + c) && (c < a + b))
                    return false;
                else return true;
            }
        }

        public string outputA() 
        {
            return Convert.ToString(a); 
        }
        public string outputB()
        {
            return Convert.ToString(b); 
        }
        public string outputC() 
        {
            return Convert.ToString(c);
        }
        public double Perimeter() 
        {
            double p = 0;
            p = a + b + c; 
            return p; 
        }
        public double Surface()
        {
            double s = 0;
            double p = 0;
            p = (a + b + c) / 2;
            s = Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
            return s;
        }

    }
}