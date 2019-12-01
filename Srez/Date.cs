using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Srez
{
    class Date
    {
        private int hour;
        public int Hour {
            get
            {
                return hour;
            }
            set
            {
                if(value < 24 && value >= 0)
                {
                    hour = value;
                }
                else
                {
                    while(value > 24)
                    {
                        value -= 24; 
                    }
                    hour = value;
                }
            }
        }
        private int minutes;
        public int Minutes {
            get
            {
                return minutes;
            }
            set
            {
                if(value < 60 && value >= 0)
                {
                    minutes = value;
                }
                else
                {
                    while(value > 60)
                    {
                        value -= 60;
                        ++Hour;
                    }
                    minutes = value;
                }
            }
        }

        private int second;
        public int Second {
            get
            {
                return second;
            }
            set
            {
                if (value < 60 && value >= 0)
                {
                    second = value;
                }
                else
                {
                    while (value > 60)
                    {
                        value -= 60;
                        ++Minutes;
                    }
                    second = value;
                }
            }
        }

        public Date() { }
        public Date(int hour, int minutes, int second)
        {
            this.Hour = hour;
            this.Minutes = minutes;
            this.Second = second;
        }
        ~Date()
        {
            Console.WriteLine("Deleted");
        }

        public int f()
        {
            int res = this.Hour * 60 + this.minutes;
            return 24 * 60 - res;
        }

        public void f2()
        {
            this.minutes += 100;
            while(minutes > 60)
            {
                minutes -= 60;
                ++hour;
            }
        }

        public int mins()
        {
            return this.hour * 60 + this.minutes;
        }

        public override string ToString()
        {
            return "Hour " + Hour + "\n" + "Minutes " + Minutes + "\n" + "Second " + Second + "\n";
        }
    }
}
