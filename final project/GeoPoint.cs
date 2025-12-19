using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_project
{
    class GeoPoint
    {
        public double xCoord;
        public double yCoord;

        public GeoPoint(double xCoord, double yCoord)
        {
            this.xCoord = xCoord;
            this.yCoord = yCoord;
        }
        public double Distance(GeoPoint target)
        {
            return Math.Sqrt((this.xCoord - target.xCoord) * (this.xCoord - target.xCoord) + (this.yCoord - target.yCoord) * (this.yCoord - target.yCoord));
        }
    }
}