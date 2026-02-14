using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solve_task_day7_c_
{
    internal class Rectangle : Shape , Ishape 
    {
       public double Area
        {
            get { return Height*Width; }
        }
        public double Width { get; set; }
        public double Height { get; set; }
       


        public Rectangle(double width, double height)
        {
            Width = width; Height = height;
        }



        //public void Draw()
        //{
        //    Console.WriteLine("Drawing a Rectangle:");
        //    Console.WriteLine($"Width: {Width}");
        //    Console.WriteLine($"Height: {Height}");
        //    Console.WriteLine($"Area: {Area}");
        //}

        public override void Draw()
        {
            base.Draw();
        }

        public override double CalculateArea()
        {
            throw new NotImplementedException();
        }

        
    }
}
