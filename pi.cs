using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nilakanthapi
{
    internal class pi
    {
        private int iteration;
        public pi()
        {
            iteration = 0;
        }
        public pi(int iteration)
        {
            this.iteration = iteration;
        }
        public double CalcPi()
        {
            double value = 3;
            double bookmark = 2;
            for(int i = 0; i < this.iteration; i++)
            {
                value += (4 / (bookmark * (bookmark + 1) * (bookmark + 2)) - 4 / ((bookmark + 2) * (bookmark + 3) * (bookmark + 4)));
                bookmark += 4;
            }
            return value;
        }
    }
}
