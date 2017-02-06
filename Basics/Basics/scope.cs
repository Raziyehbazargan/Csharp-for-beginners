using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    class Scope
    {
        private static string k = "";
        static void Main(string[] args)
        {
            string j = "";
            for (int i = 0; i < 10; i++)
            {
                j = i.ToString();
                k = i.ToString();
                Console.WriteLine(i);
                 
                if (i == 9)
                {
                    string l = i.ToString();
                }
                // Console.WriteLine(l);
                //we don't have access "l" outside the if block

            }

            // Console.WriteLine(i); we don't have access "i" outside the for block
            Console.Write("Outside of the for: " + j);
            Console.Write("Outside of the for: " + k);

            Console.ReadLine();
        }

        static void HelperMEthod()
        {
            Console.WriteLine("Value of the k from the HelperMEthod(): " + k);
        }
        
    }


    /*Accessibility Modifiers : These are accessibility modifieres
    They are used to implement attended Object Oriented Programming called ENCAPSULATION.
      1- Public: a public method is what's actually going to be then called by somebody outside of the class
      2- Private : is only goin to be called by codes inside the class.
    */
    class Instances
    {
        static public void Print()
        {
            Vehicle myCar = new Vehicle();
            myCar.DoSomething();
            // we just have access to DoSomething method ( becuz it's public method)
        }


    }

    class Vehicle
    {
        public string Make { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        //Contructor
        public Vehicle()
        {
            Year = 1986;
        }

        public void DoSomething()
        {
            Console.WriteLine(HelperMethod());
        }

        private string HelperMethod()
        {
            return "Ice-Cream";
        }
    }
}
