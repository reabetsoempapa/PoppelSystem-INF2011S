using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GoodFoodSystem.BusinessLayer;
using GoodFoodSystem.DatabaseLayer;


namespace GoodFoodSystem.PresentationLayer
{
    public partial class Checkout : Form
    {
        #region Data Members
        private Order order;
        public bool createOrderClosed = false;
        Collection<Product> products;
        OrderController controller;
        CustomerController customerController;
        decimal totalfororder;
        Customer customer;
        String id;
        Collection<OrderItem> totalItems;
        #endregion

        #region Constructor 
        public Checkout()
        {
            InitializeComponent();
            controller = new OrderController();

        }

        public Checkout(decimal total, Customer customerz, String sent, Collection<OrderItem> items)
        {
            InitializeComponent();
            controller = new OrderController();
            customerController = new CustomerController();
            customer = customerz;
            totalfororder = total;
            totalItems = items;
            id = sent;
            OrderTotalTextbox.Text = totalfororder.ToString();
            orderIDTextbox.Text = id.ToString();
            OrderTotalTextbox.ReadOnly = true;
            orderIDTextbox.ReadOnly = true;
            
        }

        public Checkout(OrderController aController)
        {
            InitializeComponent();
            controller = aController;
        }
        #endregion

        #region Utility Methods
        private void Showall()
        {
            AddressT.Visible = true;
            label7.Visible = true;
            label4.Visible = true;
            label3.Visible = true;
            label2.Visible = true;
            label5.Visible = true;
            label1.Visible = true;
            dateTimePicker.Visible = true;
            PaymentCombo.Visible = true;
            orderIDTextbox.Visible = true;
            OrderTotalTextbox.Visible = true;
            SubmitB.Visible = true;
        }
        public void populateOrder()
        {
            order = new Order();
            order.OrderId = orderIDTextbox.Text;
            order.ShipAddress = AddressT.Text;

            order.DateCreated = dateTimePicker.ToString();
            order.GrandTotal = totalfororder;
            order.OrderItem = orderIDTextbox.Text;

        }



        #endregion

        private void AddressT_TextChanged(object sender, EventArgs e)
        {

        }

        private void SubmitB_Click(object sender, EventArgs e)
        {
            if (customer.CreditStatus < 10000.00m)
            {
                populateOrder();
                customer.CreditStatus += totalfororder;
                customerController.DataMaintenance(customer, DB.DBOperation.Edit);
                customerController.FinalizeChanges(customer);
                MessageBox.Show("To be submitted to the Database!");
                controller.DataMaintenance(order, DB.DBOperation.Add);
                controller.FinalizeChanges(order);
                //this.Close();
                OrderSummary orderSummary = new OrderSummary(totalItems, totalfororder);
                orderSummary.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Customer has a bad credit Status. Customer should settle their account." +
                    "Order Put on hold");
            }
           
        }

        private void OrderTotal_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void orderIDTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Checkout_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime theDate;
            theDate = dateTimePicker.Value;
            MessageBox.Show("Selected delivery Date is " + theDate);
        }
    }

    
}
