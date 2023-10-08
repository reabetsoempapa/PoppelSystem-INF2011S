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
using System.Collections.ObjectModel;


namespace GoodFoodSystem.PresentationLayer
{
    public partial class CreateOrder : Form
    {

        #region Data Members  
        public bool createOrderClosed = false;
        Collection<Product> products;
        Collection<OrderItem> orderItems;
        OrderItemController itemController;
        ProductController controller;
        Collection<Customer> customers;
        CustomerController customerController;
        Customer customer;
        OrderItem orderItem;
        decimal total = 0;
        String orderID;
        bool CreateorderClosed;
        #endregion

        #region Utility Methods
        private void ShowAll(bool value)
        {
            productNameLabel.Visible = value;
            quantityLabel.Visible = value;


            ProductNameCombo.Visible = value;
            quantityTextbox.Visible = value;


            addToOrderButton.Visible = value;
            cancelButton.Visible = value;

            createOrderLabel.Visible = value;

        }
        private void ClearAll()
        {
            ProductNameCombo.Text = "";
            quantityTextbox.Text = "";

        }

        


        #endregion

        public Collection<OrderItem> Items
        {
            get { return orderItems; }
        }


        public CreateOrder(ProductController productController, CustomerController customerController, OrderController order)
        {
            InitializeComponent();
            products = productController.AllProducts;
            orderItem = new OrderItem();
            customers = customerController.AllCustomers;
            customer = new Customer();
            itemController = new OrderItemController();
            createOrderClosed = false;  
            



        }
        public CreateOrder()
        {
            InitializeComponent();
            //productController = productController;
            controller = new ProductController();
            products = controller.AllProducts;
            orderItems = new Collection<OrderItem>();
            customerController= new CustomerController();
            customers = customerController.AllCustomers;
            customer = new Customer();
            itemController= new OrderItemController();
            PriceTextBox.ReadOnly = true;
            availabilityTextbox.ReadOnly = true;
            createOrderClosed=false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addToOrder_Click(object sender, EventArgs e)
        {
          
            Checkout checkout = new Checkout(total, customer, orderID,orderItems);


            
            checkout.Show();
            this.Hide();

            MessageBox.Show("Products added to Cart!");

            ClearAll();
            ShowAll(false);

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            
            this.Close();

        }

        private void quantityTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProductNameCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            PriceTextBox.Text = fill_price();
            availabilityTextbox.Text = fill_Availibility();
        }
        public void fill_product_name()
        {

            foreach (Product product in products)
            {

                ProductNameCombo.Items.Add(product.ProductName);
                //quantityLabel.Text = product.Quantity.ToString();
            }

        }

        public String fill_price()
        {
            foreach (Product product in products)
            {
                if (product.ProductName == ProductNameCombo.SelectedItem.ToString())
                {
                    PriceTextBox.Text = product.ProductPrice.ToString();
                }

            }
            return PriceTextBox.Text;


        }
        public String fill_Availibility()
        {
            foreach (Product product in products)
            {
                if (product.ProductName == ProductNameCombo.SelectedItem.ToString())
                {
                    availabilityTextbox.Text = product.ProductStockCount.ToString();
                }

            }
            return availabilityTextbox.Text;

        }

        private void CreateOrder_Load(object sender, EventArgs e)
        {
            fill_product_name();
        }

        private void createOrderLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            customer = FindID();
            if (customer == null)
            {
                customerIDTextbox.ReadOnly = false;

                MessageBox.Show("Please Enter a valid customer ID");
            }
            else
            {


                try
                {
                    decimal price = decimal.Parse(PriceTextBox.Text) * decimal.Parse(quantityTextbox.Text);
                    total = total + price;
                    orderItem = PopulateOrderItem();
                    itemController.DataMaintenance(orderItem, DatabaseLayer.DB.DBOperation.Add);
                    itemController.FinalizeChanges(orderItem);
                    orderItems.Add(orderItem);


                }
                catch (Exception h)
                {
                    MessageBox.Show("Quantity must be a numeric value");
                }
            }

            customer = FindID();
            orderID = orderIDTextbox.Text.ToString();
            ProductNameCombo.ResetText();
            quantityTextbox.Clear();
            PriceTextBox.Clear();
            availabilityTextbox.Clear();
            orderIDTextbox.ReadOnly = true;
            //customerIDTextbox.ReadOnly = true;

        }



        #region My Methods 

        public OrderItem PopulateOrderItem()
        {
            orderItem = new OrderItem();
            orderItem.ItemName = ProductNameCombo.SelectedItem.ToString();
            orderItem.Quantity =int.Parse( quantityTextbox.Text);
            orderItem.Price = Convert.ToInt32(PriceTextBox.Text);
            orderItem.OrderID= orderIDTextbox.Text;
            return orderItem;

        }

        
        public Customer FindID()
        {
            foreach(Customer cust in customers)
            {
                if(cust.CustomerId == customerIDTextbox.Text)
                {
                    return cust;


                }
            }
            return null;
        }


     

        #endregion

        private void PriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void availabilityTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            createOrderClosed = true;
        }

        private void customerIDTextbox_TextChanged(object sender, EventArgs e)
        {
         
        }
    }
}
