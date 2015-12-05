using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phoney_warehouse
{
    internal class Customer
    {
        private string name;
        private string address;
        private string customerCode;
        private string phoneNumber;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string CustomerCode
        {
            get { return customerCode; }
            set { customerCode = value; }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }



    }
}
