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
            CustomerMeneger customerMeneger = new CustomerMeneger();

            ProdactMenegr prodactMenegr = new ProdactMenegr();


            customerMeneger.Add();
            customerMeneger.Uptade();
            Console.WriteLine("==================================");
            prodactMenegr.Add();
            prodactMenegr.Uptade();





        }


    }

    class ProdactMenegr
    {
        public void Add()
        {
            Console.WriteLine(" proddavr Added");

        }
        public void Uptade()
        {
            Console.WriteLine(" prodact  Uptade ");
        }
    }
    class CustomerMeneger
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
