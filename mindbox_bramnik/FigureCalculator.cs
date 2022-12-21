using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mindbox_bramnik
{
    public abstract class Figure
    {
        public double Area { get; set; }
        public abstract void CalcArea();
    }
    public class Circle : Figure
    {
        public double R { get; private set; }
        public Circle(double R)
        {
            this.R = R;
            CalcArea();
        }
        public override void CalcArea()
        {
            Area = Math.Round(Math.PI * Math.Pow(R, 2), 1);
        }
    }
    public class Triangle : Figure
    {
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }
        public bool Rectangular { get; private set; }
        public Triangle(double A, double B, double C)
        {
            if (A < 0 || B < 0 || C < 0)
                throw new ArgumentException("Длина стороны не может быть отрицательной");
            else if (A == 0 || B == 0 || C == 0)
                throw new ArgumentException("Длина стороны не может быть равна нулю");
            else if (A > (B + C) || B > (A + C) || C > (A + B))
                throw new ArgumentException("Длина стороны не может быть больше суммы длин других сторон");
            else
            {
                this.A = A;
                this.B = B;
                this.C = C;
                CalcArea();
                IsRectangular();
            }
        }
        public override void CalcArea()
        {
            double p = (A + B + C) / 2;
            Area = Math.Round(Math.Sqrt(p * (p - A) * (p - B) * (p - C)), 1);
        }
        public void IsRectangular()
        {
            Rectangular = (A == Math.Sqrt(Math.Pow(B, 2) + Math.Pow(C, 2))
                             || B == Math.Sqrt(Math.Pow(A, 2) + Math.Pow(C, 2))
                             || C == Math.Sqrt(Math.Pow(A, 2) + Math.Pow(B, 2)));
        }
    }
}