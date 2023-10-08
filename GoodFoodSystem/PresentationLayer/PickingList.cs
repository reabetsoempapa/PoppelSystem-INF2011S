using GoodFoodSystem.BusinessLayer;
using GoodFoodSystem.DatabaseLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public partial class PickingList : Form
    {
        #region Variables
        public bool pickingListFormClosed;
        private Collection<Product> order;
        private ProductController productController;
        private FormStates state;
        private Product product;
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
        public PickingList(ProductController itemController)
        {
            InitializeComponent();
            productController = itemController;
            this.Load += PickingList_Load;
            this.Activated += PickingList_Activated;
            this.FormClosed += PickingList_FormClosed;
            state = FormStates.View;
        }
        #endregion

        #region The List View
        public void setUpPickingListView()
        {
            Collection<Product> products;

            ListViewItem productDetails;   //Declare variables

            //Clear current List View Control
            pickingListView.Clear();

            //Set Up Columns of List View
            pickingListView.Columns.Insert(0, "ProductID", 120, HorizontalAlignment.Left);
            pickingListView.Columns.Insert(1, "Name", 120, HorizontalAlignment.Left);
            pickingListView.Columns.Insert(2, "Description", 150, HorizontalAlignment.Left);
            pickingListView.Columns.Insert(3, "Price", 100, HorizontalAlignment.Left);
            pickingListView.Columns.Insert(4, "Supplier", 120, HorizontalAlignment.Left);
            pickingListView.Columns.Insert(5, "Expiry Date", 150, HorizontalAlignment.Left);
            pickingListView.Columns.Insert(6, "Quantity", 120, HorizontalAlignment.Left);
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
                productDetails.SubItems.Add(item.ExpiryDate.ToString());
                productDetails.SubItems.Add(item.Quantity.ToString());


                pickingListView.Items.Add(productDetails);
            }
            pickingListView.Refresh();
            pickingListView.GridLines = true;
        }


        #endregion


        #region Form states
        private void PickingList_Activated(object sender, EventArgs e)
        {
            pickingListView.View = View.Details;
            setUpPickingListView();
            ShowAll(false);

        }

        private void PickingList_FormClosed(object sender, FormClosedEventArgs e)
        {
            pickingListFormClosed = true;

        }
        private void PickingList_Load(object sender, EventArgs e)
        {
            pickingListView.View = View.Details;
        }
        #endregion

        #region Utility Methods

        private void ShowAll(bool value)
        {
            productIDLabel.Visible = value;
            nameLabel.Visible = value;
            descriptionLabel.Visible = value;
            priceLabel.Visible = value;
            supplierLabel.Visible = value;
            quantityLabel.Visible = value;
            expiryDateLabel.Visible = value;


            productIDTextbox.Visible = value;
            nameTextbox.Visible = value;
            descriptionTextbox.Visible = value;
            priceTextbox.Visible = value;
            supplierTextbox.Visible = value;
            quantityTextbox.Visible = value;
            expiryDateTextbox.Visible = value;


            //If the form state is View, the Submit button and the Edit button should not be visible
            if (state == FormStates.Delete)
            {
                cancelButton.Visible = !value;
                confirmButton.Visible = !value;
            }
            else
            {
                cancelButton.Visible = value;
                confirmButton.Visible = value;
            }
            deleteButton.Visible = value;

        }

        private void EnableEntries(bool value)
        {

            if (state == FormStates.Delete)
            {
                cancelButton.Visible = !value;
                confirmButton.Visible = !value;
            }
            else
            {
                cancelButton.Visible = value;
                confirmButton.Visible = value;
            }
        }

        private void ClearAll()
        {
            productIDTextbox.Text = "";
            nameTextbox.Text = "";
            descriptionTextbox.Text = "";
            priceTextbox.Text = "";
            supplierTextbox.Text = "";
            quantityTextbox.Text = "";
            expiryDateTextbox.Text = "";
        }


        private void PopulateTextBoxes(Product product)
        {

            productIDTextbox.Text = product.ProductId;
            nameTextbox.Text = product.ProductName;
            descriptionTextbox.Text = product.ProductDescription;
            priceTextbox.Text = Convert.ToString(product.ProductPrice);
            supplierTextbox.Text = product.ProductSupplier;
            quantityTextbox.Text = Convert.ToString(product.Quantity);
            expiryDateTextbox.Text = Convert.ToString(product.ExpiryDate);

        }

        private void PopulateObject()
        {
            product = new Product();
            product.ProductId = productIDTextbox.Text;
            product.ProductName = nameTextbox.Text;
            product.ProductDescription = descriptionTextbox.Text;
            product.ProductPrice = decimal.Parse(priceTextbox.Text);
            product.ProductSupplier = supplierTextbox.Text;
            product.Quantity = int.Parse(quantityTextbox.Text);
            product.ExpiryDate =(expiryDateTextbox.Text);
        }
        #endregion


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            PopulateObject();
            if (state == FormStates.Delete)
            {
                productController.DataMaintenance(product, DB.DBOperation.Delete);

            }
            productController.FinalizeChanges(product);
            ClearAll();
            state = FormStates.View;
            ShowAll(false);
            setUpPickingListView();   //refresh List View
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            state = FormStates.Delete;
            confirmButton.Visible = true;
            productController.DataMaintenance(product, DB.DBOperation.Delete);
            productController.FinalizeChanges(product);
            ClearAll();
            state = FormStates.View;
            ShowAll(false);
            setUpPickingListView();
        }

        private void pickingListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowAll(true);
            state = FormStates.View;
            EnableEntries(false);
            if (pickingListView.SelectedItems.Count > 0)   // if you selected an item 
            {
               product = productController.Find(pickingListView.SelectedItems[0].Text);  //selected employee becoms current employee
               //product = productController.Find(Convert.ToString(pickingListView.SelectedItems[0]));  //selected employee becomes current employee
                PopulateTextBoxes(product);

            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            pickingListFormClosed = true;
            this.Close();


        }
    }
}
