using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_project
{
    class Triangle: Geometry
    {
        public Triangle(GeoPoint[] pointArr): base(3, pointArr)
        {
        }
   
        public double Area()
        {
            double p = Perimeter() / 2;
            return Math.Sqrt(p * (p - side_length[0]) * (p - side_length[1]) * (p - side_length[2]));
        }

        public bool isValid()
        {
            for (int i = 0; i <= 2; i++)
            {
                if ((Math.Abs(side_length[i] + side_length[(i + 1) % 3] - side_length[(i + 2) % 3]) < Tol))
                    return false;
            }
            return true;
        }

        public bool isRight()
        {

            for (int i = 0; i <= 2; i++)
            {
                if ((Math.Abs(s[i] * s[i] + s[(i + 1) % 3] * s[(i + 1) % 3] - s[(i + 2) % 3] * s[(i + 2) % 3]) < Tol))
                    return true;
            }
            return false;
        }

        public bool isAcute()
        {
            bool flag = true;
            for (int i = 0; i <= 2; i++)
            {
                if (side_length[i] * side_length[i] - side_length[(i + 1) % 3] * side_length[(i + 1) % 3] - side_length[(i + 2) % 3] * side_length[(i + 2) % 3] > Tol)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
        public int ShapeType()
        {
            if (isRight())
                return 1;
            else if (isAcute())
                return 2;
            else
                return 3;
        }
        public double RadiusOfCircumcircle()
        {
            double CosAlpha = (side_length[1] * side_length[1] + side_length[2] * side_length[2] - side_length[0] * side_length[0]) / (2 * side_length[1] * side_length[2]);
            double SinAlpha = Math.Sqrt(1 - CosAlpha * CosAlpha);
            return 0.5 * s[0] / SinAlpha;
        }

        public string PropertyString()
        {
            if (!isValid()) return "此三點無法形成三角形";
            string str = "";
            if (ShapeType() == 1) str += "直角三角形";
            else if (ShapeType() == 2) str += "銳角三角形";
            else str += "鈍角三角形";

            str += "\n";
            str += "周長: " + Perimeter().ToString();
            str += "\n";
            str += "面積: " + Area().ToString();
            str += "\n";
            str += "外接圓半徑: " + RadiusOfCircumcircle().ToString();

            return str;

        }
    }
}