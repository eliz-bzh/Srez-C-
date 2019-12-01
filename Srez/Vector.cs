using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Srez
{
    class Vector
    {
        private int x1;
        public int X1 {
            get
            {
                return x1;
            }
            set
            {
                x1 = value;
            }
        }
        public int x2 { get; set; }
        public int y1 { get; set; }
        public int y2 { get; set; }

        public Vector() { }
        public Vector(int x1, int x2, int y1, int y2)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
        }

        ~Vector()
        {
            Console.WriteLine("Deleted");
        }

        public double length()
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}
