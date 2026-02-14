using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solve_task_day7_c_
{
    internal class Car : Movelable
    {
        #region attributes
        private int id;
        private string brand;
        private int price;
        #endregion

        #region prop
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        #endregion


        #region Constructor

        public Car()
        {

        }

        public Car (int _id)
        {
            this.id = _id;
            this.brand = "hunda";
            this.price = 2000;
        }
        
        public Car(int _id, string _brand)
        {
            this.id= _id;
            this.brand = _brand;
            this.price = 2000;
        }
        
        public Car (int _id, string _brand , int _price)
        {
            this.id = _id;
            this.brand = _brand;
            this.price = _price;
        }


        #endregion


        public void print()
        {
            Console.WriteLine(this.id + " " + this.brand+ " " +this.price);
        }

        public void Move()
        {
            Console.WriteLine("car is move");
        }

    
    }
}
