using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace solve_task_day7_c_
{
    internal class Culc
    {
        public int sum(int a, int b)
        {
            return a + b;
        }

        public int sum(int a, int b, int c)
        {
            return a + b + c;
        }

        public double sum(double a, double b)
        {
            return a * b ;
        }
    }
}
