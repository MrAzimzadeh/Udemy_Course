//using Microsoft.Analytics.Interfaces;
//using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CsharpYoutube
{
    internal class Customer
    {

        //field 
//        public string FirstName;


        //property
        public int Id { get; set; }

        //private string firstName;
        /*
        public string FirstName 
        {
            get 
            {
                return  " Mr." + firstName;
            }
            set
            {
                firstName = value;
            }
        }
        */
        public string FirstName { get; set; }

        public string LasTname { get; set; }
        public string City { get; set; }
    }
}