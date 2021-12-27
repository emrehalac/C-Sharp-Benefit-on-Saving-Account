using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Customer
    {
        public double Principal { get; set; }
        public int Period { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Boolean SpecialCustomer;

        public double Benefit { get; set; }

        


        public Customer(double principal, int period, string firstName, string lastName)
        {
            this.Principal = principal;
            this.Period = period;
            this.FirstName = firstName;
            this.LastName = lastName;
            CustomerType();
            
        }
        private void CustomerType()
        {
            if (this.Principal >= 100000)
            {
                SpecialCustomer = true;

            } 
        }
    }
}
