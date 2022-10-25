using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
          //  Intro();
            //string sentencce = NewMethod();
            string sentencce = " My name is Engin Demirog ";

            bool result4 = sentencce.StartsWith(" My name");

            Console.WriteLine("  salam " + result4);


            string sentence = "My Name  ";
            
            bool result5 = sentence.StartsWith("m");

            
            Console.WriteLine(result5);

            
            var result6 = sentencce.IndexOf(" name ");


            Console.WriteLine(result6);


           // Console.ReadLine();

            var result7 = sentencce.IndexOf(" ");
            Console.WriteLine(result7); 
            var result8 = sentencce.LastIndexOf(" ");
            Console.WriteLine(result8);
            //
            var result9 = sentencce.Insert(0 , "hello ");

            Console.WriteLine(result9);

            var result01 = sentencce.Substring(4,4);
            Console.WriteLine(result01);

        }

        private static string NewMethod()
        {
            string sentencce = " My name is Engin Demirog";
            var result = sentencce.Length;

            var result2 = sentencce.Clone();
            Console.WriteLine(result2);


            bool result3 = sentencce.EndsWith("g");
            Console.WriteLine(result3);
            return sentencce;
        }

        private static void Intro()
        {
            string City = "Ankara ";
            /*
            Console.WriteLine(City[0]);
            foreach (var item in City)
            {
                Console.WriteLine(item);
            }
            */
            string City2 = "Istanbul";
            //string City3 = City + City2;

            //Console.WriteLine(City3);

            Console.WriteLine(String.Format("{0} {1}", City, City2));

            Console.ReadLine();

        }
    }
}
