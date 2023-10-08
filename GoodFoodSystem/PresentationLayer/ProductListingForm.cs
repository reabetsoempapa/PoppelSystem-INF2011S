using GoodFoodSystem.BusinessLayer;
using GoodFoodSystem.DatabaseLayer;
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
using System.Drawing.Printing;
using static System.Windows.Forms.AxHost;

namespace GoodFoodSystem.PresentationLayer
{
    public partial class ProductListingForm : Form
    {

        #region Variables
        private Collection<Product> products;
        private Product product;
        private ProductController productController;
        public bool productListingFormClosed = false;
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
        public ProductListingForm(ProductController itemController)
        {
            InitializeComponent();
            productController = itemController;
            this.Load += ProductListingForm_Load;
            this.Activated += ProductListingForm_Activated;
            this.FormClosed += ProductListingForm_FormClosed;
            state = FormStates.View;


        }
        #endregion


        #region Utility Methods
        private void ShowAll(bool value)
        {
            productListLabel.Visible = value;

            productListView.Visible = value;

            exitButton.Visible = value;


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
        private void ClearAll()
        {
            productListView.Text = "";

        }


        private void PopulateObject()
        {
            product = new Product();


        }
        #endregion


        #region The List View
        public void setUpProductListView()
        {
            Collection<Product> products;

            ListViewItem productDetails;   //Declare variables

            //Clear current List View Control
            productListView.Clear();

            //Set Up Columns of List View
            productListView.Columns.Insert(0, "ProductID", 120, HorizontalAlignment.Left);
            productListView.Columns.Insert(1, "Name", 120, HorizontalAlignment.Left);
            productListView.Columns.Insert(2, "Description", 150, HorizontalAlignment.Left);
            productListView.Columns.Insert(3, "Price", 100, HorizontalAlignment.Left);
            productListView.Columns.Insert(4, "Supplier", 120, HorizontalAlignment.Left);
            productListView.Columns.Insert(5, "Expiry Date", 150, HorizontalAlignment.Left);
            productListView.Columns.Insert(6, "StockCount", 120, HorizontalAlignment.Left);
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
                productDetails.SubItems.Add(item
                    
                    .ProductStockCount.ToString());


                productListView.Items.Add(productDetails);
            }
            productListView.Refresh();
            productListView.GridLines = true;
        }


        #endregion

        private void exitButton_Click(object sender, EventArgs e)
        {
            productListingFormClosed = true;
            this.Close();

        }

        #region Form Events
        private void ProductListingForm_Load(object sender, EventArgs e)
        {
            productListView.View = View.Details;

        }

        private void ProductListingForm_Activated(object sender, EventArgs e)
        {
            productListView.View = View.Details;
            setUpProductListView();
            ShowAll(true);
        }

        private void ProductListingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
           productListingFormClosed = true;
        }
        #endregion

        private void printReportButton_Click(object sender, EventArgs e)
        {
            PrintDialog print = new PrintDialog();
            DialogResult result = print.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDocument1.Print();
            }
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void generateExpiredListButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font mainHeading = new Font("Times New Roman", 24);
            Font heading = new Font("Times New Roman", 16);
            Font text = new Font("Times New Roman", 12);

            
            float headingSpacing = heading.Height + 4;
            float textSpacing = text.Height + 2;

            float marginH = e.MarginBounds.Left;
            float marginV = e.MarginBounds.Top;
            

            string productsExpired = "";
            productsExpired = "EXPIRED PRODUCTS REPORT";

            e.Graphics.DrawString(productsExpired, mainHeading, Brushes.Plum, marginH, marginV);
            marginV = marginV + headingSpacing;

            productsExpired = "All Products that are currently expired: ";

            e.Graphics.DrawString(productsExpired,heading,Brushes.Plum, marginH, marginV);
            marginV = marginV + headingSpacing;
            Collection<Product> expiredProducts = new Collection<Product>();
            products = productController.AllProducts;
            foreach(Product product in products)
            {
                //DateTime expiry = DateTime.Parse("12/12/2021 05:50:06");
                 DateTime expiry = DateTime.Parse(product.ExpiryDate);

                if (DateTime.Now > expiry) 
                {
                expiredProducts.Add(product);   
                
                } 
            }
            foreach(Product expiredItems in expiredProducts)
            {
                string productsExpiredDetails = "ProductID: "+ expiredItems.ProductId + " Name: " + expiredItems.ProductName  + " Expiry Date: " + expiredItems.ExpiryDate + " Stock Count: " + expiredItems.ProductStockCount;
                e.Graphics.DrawString(productsExpiredDetails, text, Brushes.Black, marginH, marginV);
                marginV = marginV + textSpacing;


            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
    }
}
