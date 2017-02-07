using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            /*
            myCar.Make = "Oldmobile";
            myCar.Model = "Cutlas Supreme";
            myCar.Year = 1986;
            myCar.Color = "Silver";
            */
           
            Car myThirdCar = new Car("Ford", "Supreme", 2005, "Red");
            Console.WriteLine("My New Car {0}", myThirdCar.Make);

            //create new refrence to the same bucket in the memory
            Car myOtherCar;
            myOtherCar = myCar;

            Console.WriteLine("{0} {1} {2} {3} ",
                myOtherCar.Make,
                myOtherCar.Model,
                myOtherCar.Year,
                myOtherCar.Color);

            myOtherCar.Model = "Model-98";

            Console.WriteLine("{0} {1} {2} {3} ",
                myCar.Make,
                myCar.Model,
                myCar.Year,
                myCar.Color);

            //remove the handle to that bucket in the memory
            //myOtherCar = null;

            //remove all the refrences to the bucket
            //mycar = null;

            // we call this situation "garbage collection"

            Console.ReadLine();
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        //Constructor: is a method that allows us as developers to execute code at moment that a new instance of a class is created
        // by default, whenever we compile ur code, autimaticaly it will create a constructor without any input parameters for our classes.
        // like this ==> //public Car() { }
        public Car()
        {
            Make = "Nissan";
        }

        //create overloaded constructor
        public Car(string make, string mode, int year, string color)
        {
            Make = make;
            Model = Model;
            Year = year;
            Color = color;
        }
    }
}

