using System;
using System.Collections.Generic;
using System.Linq;

namespace final_project
{
    class Tetragon
    {
        public GeoPoint[] ptArr = new GeoPoint[4];
        public const double Tol = 1e-10;

        public Tetragon(GeoPoint[] pointArr)
        {
            if (pointArr.Length != 4)
                throw new ArgumentException("Tetragon requires exactly 4 points.");

            ptArr = pointArr;
            SortPointsClockwise();
        }

        private void SortPointsClockwise()
        {
            // 1. Calculate Centroid
            double cx = 0, cy = 0;
            foreach (var p in ptArr)
            {
                cx += p.xCoord;
                cy += p.yCoord;
            }
            cx /= 4;
            cy /= 4;

            // 2. Sort based on the angle (Atan2) relative to the centroid
            Array.Sort(ptArr, (a, b) =>
            {
                double angleA = Math.Atan2(a.yCoord - cy, a.xCoord - cx);
                double angleB = Math.Atan2(b.yCoord - cy, b.xCoord - cx);
                return angleA.CompareTo(angleB);
            });
        }

        private void SideLengths(double[] side)
        {
            for (int i = 0; i < 4; i++)
                side[i] = ptArr[i].Distance(ptArr[(i + 1) % 4]);
        }

        private void DiagonalLengths(double[] diag)
        {
            diag[0] = ptArr[0].Distance(ptArr[2]);
            diag[1] = ptArr[1].Distance(ptArr[3]);
        }

        public double Perimeter()
        {
            double[] s = new double[4];
            SideLengths(s);
            return s.Sum();
        }

        public double Area()
        {
            double sum1 = 0;
            double sum2 = 0;

            for (int i = 0; i < 4; i++)
            {
                sum1 += ptArr[i].xCoord * ptArr[(i + 1) % 4].yCoord;
                sum2 += ptArr[i].yCoord * ptArr[(i + 1) % 4].xCoord;
            }

            return Math.Abs(sum1 - sum2) / 2.0;
        }

        public bool isValid()
        {
            if (Area() < Tol) return false;

            double[] s = new double[4];
            SideLengths(s);
            double sum = s.Sum();
            double max = s.Max();

            if (max >= (sum - max) - Tol) return false;

            return true;
        }

        private bool areOppositeSidesEqual(double[] s)
        {
            return Math.Abs(s[0] - s[2]) < Tol && Math.Abs(s[1] - s[3]) < Tol;
        }

        private bool areAllSidesEqual(double[] s)
        {
            return Math.Abs(s[0] - s[1]) < Tol &&
                   Math.Abs(s[1] - s[2]) < Tol &&
                   Math.Abs(s[2] - s[3]) < Tol;
        }

        private bool areDiagonalsEqual(double[] d)
        {
            return Math.Abs(d[0] - d[1]) < Tol;
        }

        private bool isTrapezoid()
        {
            double x0 = ptArr[1].xCoord - ptArr[0].xCoord; double y0 = ptArr[1].yCoord - ptArr[0].yCoord;
            double x1 = ptArr[2].xCoord - ptArr[1].xCoord; double y1 = ptArr[2].yCoord - ptArr[1].yCoord;
            double x2 = ptArr[3].xCoord - ptArr[2].xCoord; double y2 = ptArr[3].yCoord - ptArr[2].yCoord;
            double x3 = ptArr[0].xCoord - ptArr[3].xCoord; double y3 = ptArr[0].yCoord - ptArr[3].yCoord;

            bool pair1 = Math.Abs(x0 * y2 - y0 * x2) < Tol;
            bool pair2 = Math.Abs(x1 * y3 - y1 * x3) < Tol;

            return pair1 || pair2;
        }

        public int ShapeType()
        {
            double[] s = new double[4];
            double[] d = new double[2];
            SideLengths(s);
            DiagonalLengths(d);

            bool allSidesEq = areAllSidesEqual(s);
            bool oppSidesEq = areOppositeSidesEqual(s);
            bool diagsEq = areDiagonalsEqual(d);

            if (allSidesEq && diagsEq) return 1;      // Square
            if (oppSidesEq && diagsEq) return 2;      // Rectangle
            if (allSidesEq) return 3;                 // Rhombus
            if (oppSidesEq) return 4;                 // Parallelogram
            if (isTrapezoid()) return 5;              // Trapezoid
            return 6;                                 // General
        }
        public double RadiusOfCircumcircle()
        {
            double[] s = new double[4];
            double[] d = new double[2];
            SideLengths(s);
            DiagonalLengths(d);

            double ptolemyDiff = Math.Abs((d[0] * d[1]) - ((s[0] * s[2]) + (s[1] * s[3])));

            if (ptolemyDiff > 1e-5) return 0;

            double semiP = Perimeter() / 2;
            double numer = (s[0] * s[1] + s[2] * s[3]) * (s[0] * s[2] + s[1] * s[3]) * (s[0] * s[3] + s[1] * s[2]);
            double denom = (semiP - s[0]) * (semiP - s[1]) * (semiP - s[2]) * (semiP - s[3]);

            if (denom <= 0) return 0;
            return 0.25 * Math.Sqrt(numer / denom);
        }

        public string PropertyString()
        {
            if (!isValid()) return "此四點無法形成四邊形";

            string str = "";
            int type = ShapeType();

            switch (type)
            {
                case 1: str += "正方形"; break;
                case 2: str += "長方形"; break;
                case 3: str += "菱形"; break;
                case 4: str += "平行四邊形"; break;
                case 5: str += "梯形"; break;
                default: str += "一般四邊形"; break;
            }

            str += "\n周長: " + Perimeter().ToString("F2");
            str += "\n面積: " + Area().ToString("F2");

            double R = RadiusOfCircumcircle();
            if (R > 0)
            {
                str += "\n外接圓半徑: " + R.ToString("F2");
            }
            return str;
        }
    }
}