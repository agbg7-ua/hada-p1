using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hada_p1
{
    class HadaP1
    {
        public static double Seconds2Minutes(double s)
        {
            double i = 0;
            if(s == 0)
            {
                i = 0;
            }
            else
            {
                i = s / 60;
            }
            return i;
        }
        public static double Minutes2Seconds(double m)
        {
            double i = 0;
            if (s == 0)
            {
                i = 0;
            }
            else
            {
                i = s * 60;
            }
            return i;
        }

    }
}
