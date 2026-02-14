using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace solve_task_day7_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region problem_1

            //Car c1 = new Car();
            //c1.print();

            //Car c2 = new Car(1);
            //c2.print();

            //Car c3 = new Car(2, "hunda");
            //// c3.print()
            //c3.ID = 5;
            //c3.print();

            //Car c4 = new Car(3, "toyota", 5000);
            //c4.print();
            //In C#, when you do not define any constructor in a class,
            //the compiler automatically provides a default parameterless constructor that simply initializes fields to their default values
            #endregion


            #region problem_2

            //Culc culc = new Culc();
            //var sum = culc.sum(1, 2);
            //Console.WriteLine(sum);

            //var sum = culc.sum(3,4,5);
            //Console.WriteLine(sum);

            //var sum = culc.sum(3.5, 5.3);
            ////Console.WriteLine(sum);
            ///Method overloading means defining multiple methods with the same name but different parameter lists 
            ///(different number, type, or order of parameters).
            #endregion

            #region problem_3
            //Child c1 = new Child(1,2,3);
            //c1.DisplayChild();


            //c1.DisplayParent();

            //Constructor chaining in inheritance means that a derived class constructor calls a base class constructor using the base() keyword.

            #endregion

            #region problem_4

            //override
            //Used to provide a new implementation of a base class method using runtime polymorphism.
            //new
            //Used to hide a base class method, not override it.
            #endregion

            #region problem_5

            // Parent p = new Parent(3, 5);

            //string ans = p.ToString();
            // Console.WriteLine(ans);

            // Child c = new Child(2,4,5);

            // ans = c.ToString();

            // Console.WriteLine(ans);

            //ToString() is often overridden in custom classes to provide a meaningful string representation of an object instead of the default class name.
            #endregion

            #region problem_6
            //            Rectangle r1 = new Rectangle(4, 6);
            //            double ans = r1.Area;
            //            Console.WriteLine(ans);
            //            r1.Draw();

            //            //Because interfaces:

            //            Have no implementation

            //            Have no constructors

            //             Cannot create objects

            #endregion

            #region problem_7

            //Circle circle = new Circle(4.6);
            //circle.Print_Details();

            //You can add new methods to interfaces without breaking existing classes
            //Common logic can be written once in the interface instead of repeating it in multiple classes.

            #endregion

            #region problem_8
            //Car c = new Car();
            //c.Move();

            //Using an interface reference enables polymorphism, promotes loose coupling, improves maintainability

            #endregion

            #region problem_9
            //File file = new File();
            //file.Read(); 
            //file.Write();
            //C# supports only single inheritance for classes, meaning a class can inherit from only one base class
            //Multiple class inheritance can cause issues like:
            //Name conflicts
            //Diamond problem
            #endregion

            #region problem_ 10
            //Rectangle r = new Rectangle(1, 4);
            //r.Draw();
            //r.CalculateArea();
            //Virtual Method
            //Has a default implementation in the base class
            //Override is optional
            //Abstract Method
            //Has no implementation
            //Must be overridden in derived class
            //Must be inside an abstract class
            #endregion

            #region part2 _ problem_2
            //Besides inheritance (IS-A), other class relationships include association (uses), aggregation (weak Has-A),
            //composition (strong Has-A), dependency (temporary use), and realization (implements interface),
            //each representing different levels of connection and ownership between classes.
            #endregion
        }
    }
}
