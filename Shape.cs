using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solve_task_day7_c_
{
    internal abstract class Shape
    {
        public string Name { get; set; }

        //public Shape (string name)
        //{
        //    this.Name = name;
        //}

        public virtual void Draw()
        {
            Console.WriteLine("Drawing Shape");
        }

        public abstract double CalculateArea();

    }
}
