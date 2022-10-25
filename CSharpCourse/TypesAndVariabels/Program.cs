using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariabels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //////////////////////////////////////////////////////////////////////////////////////

            //valu types (Deyer TIpleri
            int numberOne = int.MaxValue;//32bit
            Console.WriteLine(" NumberOne is {0} " , numberOne); // 2147483647
            long number2    = long.MaxValue;//64bit
            Console.WriteLine( " nummber2 is {0} ",number2); // 9223372036854775807
            short number3 = short.MaxValue;//16bit
            Console.WriteLine(" number3 is {0} ", number3);//32767
            byte number4 = 255;//8bit
            Console.WriteLine(number4);//255
            bool number5 = false;
            Console.WriteLine(" number5 is " +  number5);
          
            char number6 = 'a';//tek tirnaq olmalidiir
            Console.WriteLine( number6);
            Console.WriteLine(" number6 is {0}", (int)number6);
            //
            double number7 = 10.4;
            Console.WriteLine("Number7 is {0}",number7);
            decimal number8 = 100.55M;
            Console.WriteLine(number8);
            Console.WriteLine((int)Days.Friday);
            Console.ReadLine();



        }
        
    }

    //MAGICSTRING
    enum Days
        // 0     1         2          3       4       5     
    {
        Monday, Tuesday , Wednesday, Friday, Sunday, Saturday 
    }

}
