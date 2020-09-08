using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM1
{
    public class AddressRepositry
    {
        public Address Retrieve(int addressId)
        {
            Address address = new Address(addressId);

            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Bag End";
                address.StreetLine2 = "Bagshot row";
                address.City = "Gurgaon";
                address.State = "Haryana";
                address.Country = "India";
                address.PostalCode = "122";

            }
            return address;
        }
        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Bag End",
                StreetLine2 = "Bagshot row",
                City = "Gurgaon",
                State = "Haryana",
                Country = "India",
                PostalCode = "122"

            };
            addList.Add(address);
            address = new Address(2)
            {
                AddressType = 1,
                StreetLine1 = "Bag End 1",
                StreetLine2 = "Bagshot row 1",
                City = "Gurgaon",
                State = "Haryana",
                Country = "India",
                PostalCode = "122"

            };
            addList.Add(address);
            return addList;
        }

        public bool Save(Address address)
        {
            return true;
        }
    }
}
