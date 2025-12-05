using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_project
{
    class Point
    {
        public double xCoord;
        public double yCoord;
        public double Distance(Point target)
        {
            return Math.Sqrt((this.xCoord - target.xCoord) * (this.xCoord - target.xCoord) + (this.yCoord - target.yCoord) * (this.yCoord - target.yCoord));
        }
    }
}
