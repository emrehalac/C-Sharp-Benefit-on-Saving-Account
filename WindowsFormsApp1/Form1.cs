using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer(Convert.ToDouble(txtCustomerPrincipal.Text),Convert.ToInt32(txtPeriod.Text),txtCustomerName.Text
                , txtCustomerLastName.Text);
            CustomerManager customerManager = new CustomerManager();
            customerManager.CalculateTheBenefit(customer);
            MessageBox.Show("Congratulations ! \n Your Benefit in " + txtPeriod.Text + " months is: " + customer.Benefit.ToString()
                );


            

           

        }
         private void CleanScreen()
        {
            txtCustomerName.Clear();
            txtCustomerLastName.Clear();
            txtCustomerPrincipal.Clear();
            txtPeriod.Clear();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer(Convert.ToDouble(txtCustomerPrincipal.Text), Convert.ToInt32(txtPeriod.Text), txtCustomerName.Text
               , txtCustomerLastName.Text);
            CustomerManager customerManager = new CustomerManager();
            customerManager.CalculateTheBenefit(customer);
            customerManager.AddCustomer(customer);
            
            
            foreach (Customer item in customerManager.ListCustomer())
            {
                txtListName.Text += item.FirstName + Environment.NewLine;
                txtListLastName.Text += item.LastName + Environment.NewLine;
                txtListBenefit.Text += item.Benefit.ToString() + Environment.NewLine;
            }
            CleanScreen();

        }

        private void txtCustomerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtCustomerLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtCustomerPrincipal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtPeriod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

           
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
