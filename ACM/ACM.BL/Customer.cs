using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer : EntityBase, ILoggable
    {
        //ctor for creating constructor,default constructor- constructor with no parameters
        public Customer() : this(0)//constructor chaining default const calls parameterized constructor by passing default id
        {

        }
        public Customer(int customerId)
        {
            Customerid = customerId;
            AddressList = new List<Address>();
        }
        //Backing field(private var to hold the value)
        private string _lastname;

        public string Lastname

        {
            get
            {
                return _lastname;
            }
            set
            {
                _lastname = value;
            }
        }
        //property using snippet
        //composition example b/w address and customer class making list of address like home and office add can be there
        public List<Address> AddressList { get; set; }
        public string Firstname { get; set; }
        public int CustomerType { get; set; }
        public string Emailaddress { get; set; }

        public override string ToString() => Fullname;

        //never settig the id and only getting the id.It can not be set from outside the class
        public int Customerid { get; private set; }

        public string Fullname
        {
            get
            {
                return Lastname + " " + Firstname;
            }
        }
        //VALIDATE NAMES
        public override bool Validate()
        {
            var isvalid = true;
            if (string.IsNullOrWhiteSpace(Lastname)) isvalid = false;
            if (string.IsNullOrWhiteSpace(Firstname)) isvalid = false;

            return isvalid;

        }
        //RETRIEVE CUSTOMER
        /* public Customer Retrieve(int customerId)
         {
             return new Customer();
         }

         public List<Customer> Retrieve()
         {
             //RETRIEVE ALL CUSTOMERS

             return new List<Customer>();
         }
         //SAVE CUSTOMER
         public bool save()
         {
             return true;

         }*/
        public string Log()
        {
            var logString = Customerid + ": " +
                Fullname + " " +
                "Email :" + Emailaddress + " ";
            //"Status :" + EntityState.ToString();
            return logString;
        }

        //Static members and accessed by class name
        public static int InstanceCount { get; set; }

        //all properties and  methods with public access specifier are under contract class

    }
}
