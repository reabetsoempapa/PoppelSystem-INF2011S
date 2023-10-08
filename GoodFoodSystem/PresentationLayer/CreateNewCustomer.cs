using GoodFoodSystem.BusinessLayer;
using GoodFoodSystem.DatabaseLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GoodFoodSystem.PresentationLayer
{
    public partial class CreateNewCustomer : Form
    {

        #region Data Members
        private Customer customer;
        private CustomerController customerController;//     
        public bool createNewCustomerClosed = false;
        private FormStates state;
        #endregion

        #region Enumumeration
        public enum FormStates
        {
            View = 0,
            Add = 1,
            Edit = 2,
            Delete = 3
        }
        #endregion

        #region Utility Methods
        private void ShowAll(bool value)
        {
            customerIDLabel.Visible = value;
            IDLabel.Visible = value;
            nameLabel.Visible = value;
            phoneLabel.Visible = value;
            addressLabel.Visible = value;
            emailLabel.Visible = value;

            customerIDTextbox.Visible = value;
            IDTextbox.Visible = value;
            nameTextbox.Visible = value;
            phoneTextbox.Visible = value;
            addressTextbox.Visible = value;
            emailTextbox.Visible = value;

            submitButton.Visible = value;
            cancelButton.Visible = value;

            headingLabel.Visible = value;
            customerDetailsLabel.Visible = value;
            CreditStatusTextbox.Visible = value;

            //If the form state is View, the Submit button and the Edit button should not be visible
            if (state == FormStates.Delete)
            {
                cancelButton.Visible = !value;
                submitButton.Visible = !value;
            }
            else
            {
                cancelButton.Visible = value;
                submitButton.Visible = value;
            }
            cancelButton.Visible = value;


        }
        private void EnableEntries(bool value)
        {

            if (state == FormStates.Delete)
            {
                cancelButton.Visible = !value;
                submitButton.Visible = !value;
            }
            else
            {
                cancelButton.Visible = value;
                submitButton.Visible = value;
            }
        }

        private void ClearAll()
        {
            customerIDTextbox.Text = "";
            IDTextbox.Text = "";
            nameTextbox.Text = "";
            phoneTextbox.Text = "";
            addressTextbox.Text = "";
            emailTextbox.Text = "";
            CreditStatusTextbox.Text = "";
        }

        private void PopulateTextBoxes(Customer customer)
        {

            customerIDTextbox.Text = customer.CustomerId;
            nameTextbox.Text = customer.Name;
            phoneTextbox.Text = customer.Telephone;
            addressTextbox.Text = customer.CustomerAddress;
            emailTextbox.Text = customer.CustomerEmail;
            CreditStatusTextbox.Text = customer.CreditStatus.ToString();



        }
        private void PopulateObject()
        {
            customer = new Customer();
            
            customer.CustomerId = customerIDTextbox.Text;
            customer.ID = IDTextbox.Text;
            customer.Name = nameTextbox.Text;
            customer.Telephone = phoneTextbox.Text;
            customer.CustomerAddress = addressTextbox.Text;
            customer.CustomerEmail = emailTextbox.Text;
            //customer.CreditStatus = Convert.ToDecimal(creditStatusComboBox.Text);

        }


        #endregion

        #region Constructor
        public CreateNewCustomer(CustomerController aController)
        {
            InitializeComponent();
            customerController = aController;
            this.Load += CreateNewCustomer_Load;
            this.Activated += CreateNewCustomer_Activated;
            this.FormClosed += CreateNewCustomer_FormClosed;
        }
        #endregion

        #region Form States
        private void CreateNewCustomer_Load(object sender, EventArgs e)
        {

            ShowAll(false);

        }

        private void CreateNewCustomer_Activated(object sender, EventArgs e)
        {

            ShowAll(true);
        }
        private void CreateNewCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
            createNewCustomerClosed = true;
        }
        #endregion




        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (customerIDTextbox.Text.Equals("") || customerIDTextbox.Text.Equals("")|| phoneTextbox.Text.Equals("") || addressTextbox.Text.Equals("") || emailTextbox.Text.Equals(""))
            {
                MessageBox.Show("Please fill all required fields");
               
            }
            else
            {
                try
                {
                    PopulateObject();
                    customerController.DataMaintenance(customer, DB.DBOperation.Add);
                    customerController.FinalizeChanges(customer);


                    ClearAll();
                    MessageBox.Show("A new Customer has successfully been created!");
                    this.Close();
                    ShowAll(false);

                }
                catch (Exception h)
                {
                    //MessageBox.Show("Please provide numeric values only");
                    

                }
              

            }
        }



        private void cancelButton_Click(object sender, EventArgs e)
        {
            createNewCustomerClosed = true;
            this.Close();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void customerIDTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreditStatusTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
