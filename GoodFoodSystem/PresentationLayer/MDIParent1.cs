using GoodFoodSystem.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodFoodSystem.PresentationLayer
{
    public partial class MDIParent1 : Form
    {
        #region Variables
        private int childFormNumber = 0;
        //private CreateOrder createOrder;

   //forms
        private CreateNewCustomer createNewCustomer;
        private CreateOrder createOrder;
        private CustomerListingForm customerListingForm;
        private ExpiredProducts expiredProducts;
        private Login login;
        private PickingList pickingList;
        private ProductListingForm productListingForm;
  //controller classes 
        private CustomerController customerController;
        private ProductController productController;


       

        #endregion

        #region Constructor
        public MDIParent1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            customerController = new CustomerController();
            productController = new ProductController();

        }
        #endregion

        #region create childforms
        private void ShowNewForm(object sender, EventArgs e)
        {

        }
        #endregion

        #region Create a New ChildForm 
        public void CreateNewCustomerForm()
        {
            createNewCustomer = new CreateNewCustomer(customerController);
            createNewCustomer.MdiParent = this;//Setting the MDI Parent
            createNewCustomer.StartPosition = FormStartPosition.CenterParent;
            createNewCustomer.Dock = DockStyle.Fill;
        }

        public void CreateOrderForm()
        {
            createOrder = new CreateOrder();
            createOrder.MdiParent = this;        // Setting the MDI Parent
            createOrder.Dock = DockStyle.Fill;
            createOrder.StartPosition = FormStartPosition.CenterParent;
        }
        public void CustomerListingForm()
        {
            customerListingForm = new CustomerListingForm(customerController);
            customerListingForm.MdiParent = this;//Setting the MDI Parent
            customerListingForm.StartPosition = FormStartPosition.CenterParent;
            customerListingForm.Dock = DockStyle.Fill;  
        }

        public void ExpiredProductsForm()
        {
            expiredProducts = new ExpiredProducts(productController);
            expiredProducts.MdiParent = this;        // Setting the MDI Parent
            expiredProducts.StartPosition = FormStartPosition.CenterParent;
            expiredProducts.Dock = DockStyle.Fill;
        }
        //public void LoginForm()
        //{
        //    login = new Login(customerController);
        //    login.MdiParent = this;//Setting the MDI Parent
        //    login.StartPosition = FormStartPosition.CenterParent;
        //}

        public void PickingListForm()
        {
            pickingList = new PickingList(productController);
            pickingList.MdiParent = this;        // Setting the MDI Parent
            pickingList.StartPosition = FormStartPosition.CenterParent;
            pickingList.Dock = DockStyle.Fill;
        }
        public void ProductListingForm()
        {
            productListingForm = new ProductListingForm(productController);
            productListingForm.MdiParent = this;        // Setting the MDI Parent
            productListingForm.StartPosition = FormStartPosition.CenterParent;
                productListingForm.Dock = DockStyle.Fill;
        }
        #endregion


        #region : ToolStrip Menus for Listing

        
        private void productListToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Text != "productListingForm")
                {
                    f.Close();
                }
            }
            if (productListingForm == null)
            {
                ProductListingForm();
                MdiParent = this.MdiParent;
            }
            if (productListingForm.productListingFormClosed == true)
            {
                ProductListingForm();
                MdiParent = this.MdiParent;
            }
            productListingForm.setUpProductListView();
            productListingForm.Show();

        }

        private void customerListToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region ToolStrips
     
        private void createNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Text != "createNewCustomer")
                {
                    f.Close();
                }
            }
            if (createNewCustomer == null)
            {
                CreateNewCustomerForm();
                MdiParent = this.MdiParent;
                createNewCustomer.Activate();
                createNewCustomer.Show();
            }
            if (createNewCustomer.createNewCustomerClosed == true)
            {
                CreateNewCustomerForm();
                MdiParent = this.MdiParent;
                createNewCustomer.Activate();
               createNewCustomer.Show();
            }
           
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void expiredProductsReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Text != "expiredProducts")
                {
                    f.Close();
                }
            }
            if (expiredProducts == null)
            {
                ExpiredProductsForm();
                expiredProducts.Activate();
                expiredProducts.Show();
            }
            if(expiredProducts.expiredProductsClosed == true)
            {
                ExpiredProductsForm();
                expiredProducts.Activate();
                expiredProducts.Show();
            }
            else
            {
                expiredProducts.Show();
            }
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        #endregion

        private void MDIParent1_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
        }

        private void CustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void myPickingListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Text != "pickingList")
                {
                    f.Close();
                }
            }
            if (pickingList == null)
            {
                PickingListForm();
                pickingList.Activate();
                pickingList.Show();
            }
            if (pickingList.pickingListFormClosed == true)
            {
                PickingListForm();
                pickingList.Activate();
                pickingList.Show();
            }
            else
            {
                pickingList.Show();
            }
            
        }

        private void custrListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(Form f in this.MdiChildren)
            {
                if(f.Text != "customerListingForm")
                {
                    f.Close();
                }
            }
            if (customerListingForm == null)
            {
                CustomerListingForm();
                MdiParent = this.MdiParent;
            }
            if (customerListingForm.customerListingFormClosed==true)
            {
                CustomerListingForm();
                MdiParent = this.MdiParent;

            }
            customerListingForm.setUpCustomerListView();
            //if(createNewCustomer.createNewCustomerClosed==true|| productListingForm.productListingFormClosed==true || expiredProducts.expiredProductsClosed==true ||pickingList.pickingListFormClosed == true || createOrder.createOrderClosed == true)
            //{
            //    createOrder.Close();
            //    productListingForm.Close();
            //    expiredProducts.Close();
            //    pickingList.Close();
            //    createOrder.Close();
            //}
            customerListingForm.Show();
        }

        private void createOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Text != "createOrder")
                {
                    f.Close();
                }
            }
            if (createOrder== null)
            {
                CreateOrderForm();
                MdiParent = this.MdiParent;

                createOrder.Activate();
                createOrder.Show();
            }
            if (createOrder.createOrderClosed == true)
            {
                CreateOrderForm();
                MdiParent = this.MdiParent;

                createOrder.Activate();
                createOrder.Show();
            }
            else
            {
                createOrder.Show();
            }
        }
    }
}
