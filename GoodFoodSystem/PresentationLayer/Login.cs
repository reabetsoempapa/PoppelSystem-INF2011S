using GoodFoodSystem.BusinessLayer;
using GoodFoodSystem.DatabaseLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using System.Xml;

namespace GoodFoodSystem.PresentationLayer
{
    public partial class Login : Form
    {

        #region Data Members
        private Customer customer;
        private CustomerController customerController;//     
        public bool loginClosed = false;
        private FormStates state;

        #endregion

        #region Enumeration
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
            welcomeLabel.Visible = value;

            customerIDTextbox.Visible = value;

            loginButton.Visible = value;


            //If the form state is View, the Submit button and the Edit button should not be visible
            if (state == FormStates.Delete)
            {
                loginButton.Visible = !value;
            }
            else
            {
                loginButton.Visible = value;
            }

        }
        private void EnableEntries(bool value)
        {

            if (state == FormStates.Delete)
            {
                loginButton.Visible = !value;
            }
            else
            {
                loginButton.Visible = value;
            }
        }
        private void ClearAll()
        {
            customerIDTextbox.Text = "";
         
        }

        private void PopulateTextBoxes(Customer customer)
        {

           customerIDTextbox.Text = customer.CustomerId;

        }
            private void PopulateObject()
        {
            customer = new Customer();     
            customer.CustomerId = customerIDTextbox.Text;
        }


        #endregion

        #region Constructor
        public Login()
        {
            InitializeComponent();
            //customerController = aController;
            this.Load += Login_Load;
            this.Activated += Login_Activated;
            this.FormClosed += Login_FormClosed;

        }
        #endregion


        #region Form Events

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MDIParent1 mDIParent1 = new MDIParent1();
            MessageBox.Show("you have logged in.");

            mDIParent1.Show();
            //PopulateObject();
            //customerController.DataMaintenance(customer, DB.DBOperation.Add );
            //customerController.FinalizeChanges(customer);
            //ClearAll();
            //ShowAll(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginClosed = true;
            this.Close();


        }
        #endregion

        private void createNewCustomerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateNewCustomer newcust = new CreateNewCustomer(customerController);
            newcust.Show();
       
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Login_Activated(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
