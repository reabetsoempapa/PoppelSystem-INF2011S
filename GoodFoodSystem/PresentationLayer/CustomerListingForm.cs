using GoodFoodSystem.BusinessLayer;
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
using System.Xml;
using GoodFoodSystem.DatabaseLayer;
using System.Collections.ObjectModel;
using static System.Windows.Forms.AxHost;

namespace GoodFoodSystem.PresentationLayer
{
    public partial class CustomerListingForm : Form
    {

        #region Variables
        private Collection<Customer> customers;
        private Customer customer;
        private CustomerController customerController;//
        public bool customerListingFormClosed;
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

        #region Constructor
        public CustomerListingForm(CustomerController custController)
        {
            InitializeComponent();
            customerController = custController;
            this.Load += CustomerListingForm_Load;
            this.Activated += CustomerListingForm_Activated;
            this.FormClosed += CustomerListingForm_FormClosed;
            state = FormStates.View;

        }
        #endregion

        #region Utility Methods
        private void ShowAll(bool value)
        {
            customerListLabel.Visible = value;

            customerListView.Visible = value;
            exitButton.Visible = value;

        }
        private void ClearAll()
        {
            customerListView.Text = "";

        }
        private void EnableEntries(bool value)
        {

            if (state == FormStates.Delete)
            {
                exitButton.Visible = !value;
            }
            else
            {
                exitButton.Visible = value;
            }
        }
        private void PopulateObject()
        {
            customer = new Customer();

        }
        #endregion

        #region The List View
        public void setUpCustomerListView()
        {
            Collection<Customer> customers;

            ListViewItem customerDetails;   //Declare variables

            //Clear current List View Control
            customerListView.Clear();

            //Set Up Columns of List View
            customerListView.Columns.Insert(0, "CustomerID", 120, HorizontalAlignment.Left);
            customerListView.Columns.Insert(1, "ID", 120, HorizontalAlignment.Left);
            customerListView.Columns.Insert(2, "Name", 150, HorizontalAlignment.Left);
            customerListView.Columns.Insert(3, "Phone", 100, HorizontalAlignment.Left);
            customerListView.Columns.Insert(4, "Address", 120, HorizontalAlignment.Left);
            customerListView.Columns.Insert(5, "Email", 150, HorizontalAlignment.Left);
            customerListView.Columns.Insert(5, "Credit Status", 150, HorizontalAlignment.Left);


            customers = null;
            customers = customerController.AllCustomers;

            //Add customer details to each ListView item 
            foreach (Customer cust in customers)
            {
                customerDetails = new ListViewItem();
                customerDetails.Text = cust.ID.ToString();
                customerDetails.SubItems.Add(cust.CustomerId);
                customerDetails.SubItems.Add(cust.Name);
                customerDetails.SubItems.Add(cust.Telephone);
                customerDetails.SubItems.Add(cust.CustomerAddress);
                customerDetails.SubItems.Add(cust.CustomerEmail);
                customerDetails.SubItems.Add(cust.CreditStatus.ToString());

                customerListView.Items.Add(customerDetails);
            }
            customerListView.Refresh();
            customerListView.GridLines = true;
        }
        #endregion

        #region Form Events
        private void CustomerListingForm_Load(object sender, EventArgs e)
        {
            customerListView.View = View.Details;


        }

        private void CustomerListingForm_Activated(object sender, EventArgs e)
        {
            customerListView.View = View.Details;
            setUpCustomerListView();
            ShowAll(true);
        }

        private void CustomerListingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            customerListingFormClosed = true;


        }


        #endregion

        private void exitButton_Click(object sender, EventArgs e)
        {
            customerListingFormClosed = true;
            this.Close();

        }
    }
}
