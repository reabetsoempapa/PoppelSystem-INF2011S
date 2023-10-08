using GoodFoodSystem.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodFoodSystem.PresentationLayer
{
    public partial class OrderSummary : Form

    {
        Collection<OrderItem> orderItems = new Collection<OrderItem>();
        decimal total;
        private OrderItem orderItem;
        //private FormState state;
        
        public OrderSummary()
        {
            InitializeComponent();
            this.Load += OrderSummary_Load;
            this.Activated += OrderSummary_Activated;
            this.FormClosed += OrderSummary_FormClosed;
            setUpOrderListView();
           
        }
        public OrderSummary(Collection<OrderItem> items, decimal tot)
        {
            InitializeComponent();

            this.orderItems = items;
            
            int num = orderItems.Count;

            total = tot;
            this.Load += OrderSummary_Load;
            this.Activated += OrderSummary_Activated;
            this.FormClosed += OrderSummary_FormClosed;
            setUpOrderListView();
        }

        #region The List View
        public void setUpOrderListView()
        {
            ListViewItem orderItemDetails;
            OrderItemListView.Clear();
            OrderItemListView.Columns.Insert(0, "Product Name", 120, HorizontalAlignment.Left);
            OrderItemListView.Columns.Insert(1, "Price", 120, HorizontalAlignment.Left);
            OrderItemListView.Columns.Insert(2, "Quantity", 120, HorizontalAlignment.Left);
            

            foreach(OrderItem item in this.orderItems) 
            {
                orderItemDetails = new ListViewItem();
                orderItemDetails.Text = item.ItemName;
                orderItemDetails.SubItems.Add(item.Price.ToString());
                orderItemDetails.SubItems.Add(item.Quantity.ToString());
                OrderItemListView.Items.Add(orderItemDetails);

            }
            OrderItemListView.Refresh();
            OrderItemListView.GridLines = true;
            //OrderItemListView.Columns.Insert(0, "Product Name", 120, HorizontalAlignment.Left);
        }


        public void  ShowAll(bool value)
        {
            OrderItemListView.Visible = value;
        }

        #endregion

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OrderSummary_Load(object sender, EventArgs e)
        {
            OrderItemListView.View = View.Details;
            OrderTotalTextbox.Text = total.ToString();
        }

        private void OrderSummary_Activated(object sender, EventArgs e)
        {
            OrderItemListView.View = View.Details;
            setUpOrderListView();
            ShowAll(true);
        }

        private void OrderItemListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(OrderItemListView.SelectedItems.Count > 0)
            {
                orderItem = FindItem(OrderItemListView.SelectedItems[0].Text);
            }
        }

        private void OrderSummary_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        public OrderItem FindItem(String OrderItemName)
        {
            foreach(OrderItem item2 in orderItems)
            {
                if(item2.ItemName == OrderItemName)
                {
                    return item2;
                }
            }
            return null;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            orderItems.Remove(orderItem);
            setUpOrderListView();
        }

        private void OrderTotalTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
