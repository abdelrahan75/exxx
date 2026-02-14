using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solve_task_day7_c_
{
    internal class Child : Parent
    {
        public int z;

        public int Z
        {
            get { return z; }
            set { z = value; }
        }

        public Child(int _x, int _y,int _z) : base(_x, _y)
        {
            z = _z ;
        }


        public void DisplayChild()
        {
            Console.WriteLine($"Child - X: {X}, Y: {Y}, Z: {Z}");
        }

        public new int Prudact()
        {
            return base.Y * base.X * this.z;
        }

        //public override  int Prudact()
        //{
        //    return base.Y * base.X * this.z;
        //}

        public override string ToString()
        {
            return base.ToString() +" " + this.z;
        }
    }
}
