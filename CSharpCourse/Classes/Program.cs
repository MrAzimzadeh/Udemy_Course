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
            //


            //public int MyProperty { get; set; }

            Customer customer = new Customer();
            customer.City = " Ankara  ";
            customer.Id =  1;
            customer.FisrtName = "Mahammad";
            Customer customer1 = new Customer
            {
                Id = 1,City = " Istanbul" , FisrtName = "Derin" , LastName  = "Azimzada"
            };

            Console.WriteLine(customer1.FisrtName);

        
            







        }


    }



}
