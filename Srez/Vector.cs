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

        //15
        public double length()
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }


        //17
        public Vector findDoubleLength()
        {
            return new Vector(x1, 2 * (x2 - x1), y1, 2 * (y2 - y1));
        }

        public double squareTreg()
        {
            return Math.Abs(x2 - x1) * Math.Abs(y2 - y1) / 2;
        }

        //7
        public double SqurePrim()
        {
            return Math.Abs(x2 - x1) * Math.Abs(y2 - y1);
        }

        public bool Kvadrat()
        {
            return Math.Abs(x2 - x1) == Math.Abs(y2 - y1);
        }

        //16
        public Point MiddleOfTheVector()
        {
            return new Point((x1 + x2) / 2, (y1 + y2) / 2);
        }

        public bool Angle45()
        {
            return Math.Abs(x2 - x1) == Math.Abs(y2 - y1);
        }
    }
}
