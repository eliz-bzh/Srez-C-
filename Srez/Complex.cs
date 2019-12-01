using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Srez
{
    class Complex
    {
        public double active { get; set; }
        public double passive { get; set; }

        public Complex() { }

        public Complex(double active, double passive)
        {
            this.active = active;
            this.passive = passive;
        }

        ~Complex()
        {
            Console.WriteLine("Deleted");
        }

        public override string ToString()
        {
            return "Active " + this.active + "\n" + "Passive " + this.passive + "\n";
        }

        public Complex f(int a)
        {
            return new Complex(this.active * a, this.passive * a);
        }

        public Complex abs()
        {
            return new Complex(Math.Abs(this.active), Math.Abs(this.passive));
        }

        public Complex reverse()
        {
            double denum = Math.Pow(this.active, 2) + Math.Pow(passive, 2);
            return new Complex(this.active/denum, -this.passive/denum);
        }
    }
}
