using System;
using System.Collections.Generic;
using System.Linq;

namespace final_project
{
    class Pentagon: Geometry
    {
        public Pentagon(GeoPoint[] pointArr):base(5, pointArr)
        {
        }

        public double Area()
        {
            double area = 0;
            for (int i = 0; i < 5; i++)
            {
                area += (ptArr[i].x * ptArr[(i + 1) % 5].y) - (ptArr[(i + 1) % 5].x * ptArr[i].y);
            }
            return Math.Abs(area) / 2.0;
        }

        public int ShapeType()
        {
            bool hasPositive = false;
            bool hasNegative = false;

            for (int i = 0; i < 5; i++)
            {
                // Get three consecutive points
                GeoPoint p1 = ptArr[i];
                GeoPoint p2 = ptArr[(i + 1) % 5];
                GeoPoint p3 = ptArr[(i + 2) % 5];

                // Calculate the cross product of vectors (p1->p2) and (p2->p3)
                // cp = (x2-x1)(y3-y2) - (y2-y1)(x3-x2)
                double cp = (p2.x - p1.x) * (p3.y - p2.y) - (p2.y - p1.y) * (p3.x - p2.x);

                if (cp > Tol) hasPositive = true;
                else if (cp < -Tol) hasNegative = true;

                // If signs change, it is concave
                if (hasPositive && hasNegative) return 2; 
            }

            // If all cross products have the same sign, it is convex
            return 1;
        }

        public string PropertyString()
        {
            string typeStr = "";
            int type = ShapeType();

            if (type == 1) typeStr = "凸五邊形";
            else if (type == 2) typeStr = "凹五邊形";
            else typeStr = "其他形狀";

            return $"{typeStr}\n{BasicPropString()}";
        }
    }
}