using System;

namespace Program
{
    public class Program
    {


        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int Add(int intValA = 0, int intValB = 0)
        {
            if (intValA == 0)
            {
                return intValB;
            }
            else if (intValB == 0)
            {
                return intValA;
            }
            else
            {
                return intValA + intValB;
                //git test

            }
        }
    }
}
