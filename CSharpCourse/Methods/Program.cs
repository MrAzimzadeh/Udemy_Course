using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine(Add4(1, 2, 3));


            //int number4 = 20;
            //int number3 = 100;
            //var result2 = Add3(ref number4, number3);
            //Console.WriteLine(result2);
            //Console.WriteLine(number4);


            //Add();
            ////Console.ReadLine
            //var result = Add2(20, 20);
            ////Console.WriteLine(result);
            ////Console.Readline();

            Console.WriteLine(Multiply(2, 2));

            Console.WriteLine(Multiply(2, 2, 2));




            Console.ReadLine();

        }
        static void Add()
        {
            //       Console.WriteLine("Added!!");
        }
        static int Add2(int number1, int number2 = 30)
        {
            var result = number1 + number2;
            return result;
        }
        static int Add3(ref int number4, int number3)
        {
            number4 = 30;
            return number4 + number3;
        }
        static int Add4(params int[] numbers)
        {
            return numbers.Sum();
        }

        static int Multiply(int number1, int number2)
        {

            return number1 * number2;


        }
        static int Multiply(int number1, int number2, int number3)
        {

            return number1 * number2 * number3;


        }
    }

}

