using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadiTuan
{
    public class playInfo
    {
        private Point point;

        public Point Point
        {
            get
            {
                return point;
            }

            set
            {
                point = value;
            }
        }
        public playInfo(Point point)
        {
            this.Point = point;
        }
    }
}
