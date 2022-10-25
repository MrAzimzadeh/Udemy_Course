using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpYoutube
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.add();
            product.Uptade();

            Customer customer = new Customer();
            customer.FirstName = " mahammad";
            customer.LasTname = " Azimzada ";
            customer.Id = 555;
            customer.City = " Baku";

            Customer customer1 = new Customer
            {
                Id = 2,
                City = "Baku",
                FirstName = "Ali ",
                LasTname = " Azimzada "
            };
            Console.WriteLine(customer1.FirstName);
            Console.ReadLine();
        }
    }
}
