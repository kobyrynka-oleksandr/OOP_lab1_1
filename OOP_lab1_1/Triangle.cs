using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab1_1
{
    public class Triangle
    {
        private int[] aPoint, bPoint, cPoint;
        private double[] sides = new double[3];

        public Triangle(int[] aPoint, int[] bPoint, int[] cPoint)
        {
            this.aPoint = aPoint;
            this.bPoint = bPoint;
            this.cPoint = cPoint;
            
            if (aPoint == bPoint || bPoint == cPoint || aPoint == cPoint)
                throw new Exception("Triangle cannot have several points with the same coordinates");

            FindAllSides();
        }
        public Triangle()
        {
            aPoint = new int[2];
            aPoint[0] = 0; aPoint[1] = 2;
            bPoint = new int[2];
            bPoint[0] = -1; bPoint[1] = 0;
            cPoint = new int[2];
            cPoint[0] = 1; cPoint[1] = 0;

            if (aPoint == bPoint || bPoint == cPoint || aPoint == cPoint)
                throw new Exception("Triangle cannot have several points with the same coordinates");

            FindAllSides();
        }
        public void FindAllSides()
        {
            double a = FindDistance(aPoint, bPoint);
            double b = FindDistance(bPoint, cPoint);
            double c = FindDistance(aPoint, cPoint);

            if (a >= b + c || b >= a + c || c >= a + b)
                throw new Exception("Triangle cannot have several points with the same coordinates");
            sides[0] = a; sides[1] = b; sides[2] = c;
        }
        public double FindDistance(int[] point1, int[] point2)
        {
            return Math.Sqrt(Math.Pow(point2[0] - point1[0], 2) + Math.Pow(point2[1] - point1[1], 2));
        }

        public double this[int i]
        {
            get 
            {
                if (i >= 0 &&  i < sides.Length)
                    return sides[i];
                else
                    throw new Exception("Side with this index does not exist");
            }
        }

        public double Perimeter()
        {
            return sides.Sum();
        }

        public double Area()
        {
            double p = sides.Sum() / 2;
            return Math.Sqrt(p * (p - sides[0]) * (p - sides[1]) * (p - sides[2]));
        }
        public Triangle Input()
        {
            Console.WriteLine("a point:");
            int ax = int.Parse(Console.ReadLine());
            int ay = int.Parse(Console.ReadLine());
            int[] a = { ax, ay };

            Console.WriteLine("b point:");
            int bx = int.Parse(Console.ReadLine());
            int by = int.Parse(Console.ReadLine());
            int[] b = { bx, by };

            Console.WriteLine("c point:");
            int cx = int.Parse(Console.ReadLine());
            int cy = int.Parse(Console.ReadLine());
            int[] c = { cx, cy };

            return new Triangle(a, b, c);
        }
        public void Output()
        {
            Console.WriteLine("Perimeter: " + Perimeter());
            Console.WriteLine("Area: " + Area());
        }
    }
}
