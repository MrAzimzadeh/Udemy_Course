using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();

            customerManager.Add();
            customerManager.Uptade();



        }


    }

    class CustomerManager
    {
        public void Add()
        {
            Console.WriteLine(" customer Added");

        }
        public void Uptade()
        {
            Console.WriteLine(" Customer  Uptade ");
        }
    }
}
