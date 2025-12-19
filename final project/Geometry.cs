using System;

namespace final_project
{
    public abstract class Geometry
    {
        public const double Tol = 1e-10;
        protected GeoPoint[] ptArr;
        protected int SIDE;
        protected double[] side_length;

        protected Geometry(int side, GeoPoint[] points){
            SIDE = side;
            if(points.Length != SIDE)
                throw new ArgumentException("Incorrect number of points");
            ptArr = points;
            side_length = new double[SIDE];
            SideLengths(side_length);
        }

        protected void SideLengths(double[] side)
        {
            for (int i = 0; i < SIDE; i++)
                side[i] = ptArr[i].Distance(ptArr[(i + 1) % SIDE]);
        
        }

        protected double Perimeter() {
            double peri = 0;
            for (int i = 0; i < SIDE; i++)
                peri += ptArr[i].Distance(ptArr[(i + 1) % SIDE]);
            return peri;
        }

        protected abstract double Area();
        protected abstract bool isValid();
        protected abstract int ShapeType();
        protected abstract string PropertyString();


    }
}