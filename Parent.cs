using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solve_task_day7_c_
{
    internal class Parent
    {
        protected int X { get; set; }
        protected int Y { get; set; }

        public Parent(int _x , int _y)
        {
            X = _x; Y = _y;
        }

        public void DisplayParent()
        {
            Console.WriteLine($"Parent - X: {X}, Y: {Y}");
        }

        public virtual int Prudact()
        {
            return X*Y;
        }

        public override string ToString()
        {
            return X + " " + Y;
        }
    }
}
