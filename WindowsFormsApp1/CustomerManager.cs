using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class CustomerManager
    {

        private  List<Customer> customers = new List<Customer>();
       



        public void CalculateTheBenefit(Customer customer)
        {
            double sum = 0;
            sum = customer.Principal;
            if (customer.SpecialCustomer)
            {

                for (int i = 0; i < customer.Period; i++)
                {

                    sum = sum * 1.10;

                }
            }
            else
            {
                for (int i = 0; i < customer.Period; i++)
                {
                    sum = sum * 1.05;

                }

            }
            customer.Benefit = sum - customer.Principal;
        }

        //Add Customer to List

        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);

        }
       public List<Customer> ListCustomer()
        {
            return customers;
        }
    }

}
