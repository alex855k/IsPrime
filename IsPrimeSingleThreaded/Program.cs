using System;
using System.Threading;

namespace IsPrimeSingleThreaded
{
    class Program
    {
        bool goOn = true;

        static void Main(string[] args)
        {
            Program program = new IsPrimeSingleThreaded.Program();
            program.Run();
        }

        public void Run()
        {
            do
            {
                long input = GetUserValue();
                if (input == 0)
                {
                    goOn = false;
                }
                else
                {
                    PrimeChecker pc = new PrimeChecker(input);
                    new Thread(pc.Check).Start();
                }
            } while (goOn);
        }

        private long GetUserValue()
        {
            Console.Write("Enter a positive integer value to test whether it is prime (enter 0 to exit) : ");
            try
            {
                return long.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                return 1;
            }
        }
    }
}
