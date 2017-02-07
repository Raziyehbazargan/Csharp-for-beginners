using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    class scope
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
}
