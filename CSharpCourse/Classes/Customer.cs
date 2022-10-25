using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{

    public class Customer
    {


        //property
        public int Id { get; set; }


        //encapsulation*****************************************************
        //private string _firstname;
        //public string FisrtName
        //{
        //    get
        //    {
        //        return "Mr." + _firstname;
        //    }
        //    set
        //    {
        //        _firstname = value;
        //    }
        //}
        //*****************************************************************************
        public string FisrtName { get; set; }

        public string LastName { get; set; }

        public string City { get; set; }

    }
}
