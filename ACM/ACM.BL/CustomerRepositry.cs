using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepositry
    {
        private AddressRepositry addRepo { get; set; }
        //builds a collaborative relationship btw addrepo and customerrepo
        public CustomerRepositry()

        {
            addRepo = new AddressRepositry();
        }
        public Customer Retrieve(int customerId)
        {
            //Instance of Customer Class(eg of composition)
            Customer customer = new Customer(customerId);

            //hard coded the values
            if (customerId == 1)
            {
                customer.Firstname = "Mahak";
                customer.Lastname = "Yadav";
                customer.Emailaddress = "fjkflflf@hd.sd";
                customer.AddressList = addRepo.RetrieveByCustomerId(customerId).ToList();
            }

            return customer;
        }
        public bool Save(Customer customer)
        {
            return true;
        }

    }
}
