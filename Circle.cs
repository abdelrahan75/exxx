using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solve_task_day7_c_
{
    internal class Circle : Ishape
    {
        private double PAy = 3.14;
         double H;

       

        public double Area
        {
            get { return H*PAy; }
        }

        public Circle(Double h)
        {
            H = h;
        }

        public void Print_Details()
        {
            Console.WriteLine(this.Area);
        }

        public void Draw()
        {
            Console.WriteLine(this.Area);
        }
    }
}
