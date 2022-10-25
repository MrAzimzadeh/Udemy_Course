using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string student1 = "Engin";
            //string student2 = " derin ";
            //string student3 = " Mahammad ";

            string[] Students = new string[3];
            Students[0] = " Engin ";
            Students[1] = " Derin ";
            Students[2] = " Salih  ";

            string[] Students2 = new[] { " salam ", " Qadasi ", " Necesen " };
            object[] Students3 = { 2, " salam ", " Qadasi ", " Necesen " };

            string[,] regions = new string[7, 3]
            {
                {"Masalli" , " Lenkaran " , " Astara " },
                {"Samaxi  " , " Baki  " , "  gence" },
                {"Sirvan " , " Yevlax " , " Qax " },
                {"Siyezen " , " Sag " , " Sol " },
                {"Qarabag" , " Agstafa " , " Goyygol " },
                {"Seki " , " Nardaran  " , " Lerik " },
                {"Fuzuli " , " Susa  " , " Muugan " },
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                //Console.WriteLine("***************************");
            }

            //Students[0] = " Engin ";
            //Students[1] = " Derin ";
            //Students[2] = " Salih  ";


            foreach (var Student in Students3)
            {

                Console.WriteLine(Student);

            }

        }
    }
}
