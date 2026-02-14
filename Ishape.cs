using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solve_task_day7_c_
{
    internal interface Ishape
    {
        public double Area { get; }

        public void Draw();

        public void Print_Details()
        {
            Console.WriteLine(Area);
        }
    }
}
