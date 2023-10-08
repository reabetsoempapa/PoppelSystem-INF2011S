using GoodFoodSystem.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodFoodSystem.PresentationLayer
{
    public partial class ExpiredProducts : Form
    {


        #region Data Members
        private Product product;
        private ProductController productController;//     
        public bool expiredProductsClosed = false;
        private Collection<Product> products;
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

        public ExpiredProducts(ProductController productController)
        {
            InitializeComponent();
            this.productController = productController;
        }
        #endregion


        #region Utility Methods
        private void ShowAll(bool value)
        {
            headingExpiredLabel.Visible = value;
            expiredProductListView.Visible = value;


            printButton.Visible = value;
            exitButton.Visible = value;


        }
        private void ClearAll()
        {
            expiredProductListView.Text = "";
     
        }
        private void EnableEntries(bool value)
        {

            if (state == FormStates.Delete)
            {
                exitButton.Visible = !value;
                printButton.Visible= !value;
            }
            else
            {
                exitButton.Visible = value;
                printButton.Visible = value;
            }
        }
        private void PopulateObject()
        {
            product = new Product();

        }
        #endregion

        #region The List View
        public void setUpExpiredProductstListView()
        {
            Collection<Product> products;

            ListViewItem productDetails;   //Declare variables

            //Clear current List View Control
            expiredProductListView.Clear();

            //Set Up Columns of List View
            expiredProductListView.Columns.Insert(0, "ProductID", 120, HorizontalAlignment.Left);
            expiredProductListView.Columns.Insert(1, "Name", 120, HorizontalAlignment.Left);
            expiredProductListView.Columns.Insert(2, "Description", 150, HorizontalAlignment.Left);
            expiredProductListView.Columns.Insert(3, "Price", 100, HorizontalAlignment.Left);
            expiredProductListView.Columns.Insert(4, "Supplier", 120, HorizontalAlignment.Left);
            expiredProductListView.Columns.Insert(5, "Expiry Date", 150, HorizontalAlignment.Left);
            expiredProductListView.Columns.Insert(6, "StockCount", 120, HorizontalAlignment.Left);
            products = null;
            products = productController.AllProducts;
            //Add products details to each ListView item 
            foreach (Product item in products)
            {
                productDetails = new ListViewItem();
                productDetails.Text = item.ProductId.ToString();
                productDetails.SubItems.Add(item.ProductName);
                productDetails.SubItems.Add(item.ProductDescription);
                productDetails.SubItems.Add(item.ProductPrice.ToString());
                productDetails.SubItems.Add(item.ProductSupplier);
                productDetails.SubItems.Add(item.ExpiryDate);
                productDetails.SubItems.Add(item.ProductStockCount.ToString());


                expiredProductListView.Items.Add(productDetails);
            }
            expiredProductListView.Refresh();
            expiredProductListView.GridLines = true;
        }


        #endregion
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            expiredProductsClosed = true;
            this.Close();
        }

        #region Form Events
        private void ExpiredProducts_Load(object sender, EventArgs e)
        {
            expiredProductListView.View = View.Details;

        }

        private void ExpiredProducts_FormClosed(object sender, FormClosedEventArgs e)
        {
            expiredProductsClosed = true;

        }

        private void ExpiredProducts_Activated(object sender, EventArgs e)
        {
            expiredProductListView.View = View.Details;
            setUpExpiredProductstListView();
            ShowAll(true);
        }
        #endregion

        private void printButton_Click(object sender, EventArgs e)
        {
            PrintDialog print = new PrintDialog();
            PrintDocument printD = new PrintDocument();
            printD.DocumentName = "Expired Products Report";
            print.Document = printD;
            print.AllowSomePages = true;
            print.AllowSelection = true;
            if (print.ShowDialog() == DialogResult.OK)
                printD.Print();
        }
    }
}
