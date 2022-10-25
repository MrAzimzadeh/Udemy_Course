using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();
            //NewMethod();
            //NewMethod1();
            //NewMethod2();
            //Console.WriteLine("Finsh");



            //          IsPrimeNuber(Convert.ToInt32(Console.ReadLine()));

            // Console.WriteLine(deyer);

            if (IsPrimeNuber(Convert.ToInt32(Console.ReadLine())))
            {
                Console.WriteLine("This is a prime number");
            }
            else
            {
                Console.WriteLine("This is e noot a prime number");
            }




            Console.ReadLine();
        }

        private static bool IsPrimeNuber(int number)
        {
            bool result = true;
            for (int i = 2; i < number-1; i++)
            {
                if (number %i == 0)
                {
                    result = false;
                    i = number;

                }
            }
            return result;

        }



        private static void NewMethod2()
        {
            string[] Students = new[] { " salam ", " Qadasi ", " Necesen " };
            foreach (var student in Students)
            {
                // student = " Ahmet" // sehb cunki  evvelden 3 dene deyer tanimlanib
                //
                Console.WriteLine(student);


                //


            }
        }

        private static void NewMethod1()
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;
            } while (number >= 20);
        }

        private static void NewMethod()
        {
            int number = 100;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }
            Console.WriteLine("Now number is {0}", number);
        }

        private static void ForLoop()
        {
            for (int i = 0; i <= 100; i += 2)
            {
                Console.WriteLine(i);

            }
            for (int i = 100; i >= 0; i -= 2)
            {
                Console.WriteLine(i);

            }
        }
    }
}
